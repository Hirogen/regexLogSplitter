using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitt.Pipeline
{
    public class CastingPipelineBuilder : IPipeline
    {
        private List<Func<object, object>> _pipelineSteps = new List<Func<object, object>>();
        private BlockingCollection<object>[] _buffers;


        public event Action<object> Finished;

        public void AddStep(Func<object, object> stepFunc)
        {
            _pipelineSteps.Add(stepFunc);
        }

        public void Execute(object input)
        {
            BlockingCollection<object> first = _buffers[0];
            first.Add(input);
        }

        public IPipeline GetPipeline()
        {
            //Create Buffers
            _buffers = _pipelineSteps.Select(step => new BlockingCollection<object>()).ToArray();

            int bufferIndex = 0;
            foreach (Func<object, object> pipelineStep in _pipelineSteps)
            {
                var bufferIndexLocal = bufferIndex; //with this remains same in each thread
                Task.Run(() =>
                {
                    //GetConsuminEnumerable => is blocking when the collection is empty
                    foreach (object input in _buffers[bufferIndexLocal].GetConsumingEnumerable())
                    {
                        object output = pipelineStep.Invoke(input);

                        bool isLastStep = bufferIndexLocal == _pipelineSteps.Count - 1;
                        if (isLastStep)
                        {
                            //BeginInvoke would be better https://stackoverflow.com/questions/1916095/how-do-i-make-an-eventhandler-run-asynchronously/16336361#16336361
                            Finished?.Invoke(output);
                        }
                        else
                        {
                            BlockingCollection<object> next = _buffers[bufferIndexLocal + 1];
                            next.Add(output);
                        }
                    }
                });

                bufferIndex++;
            }

            return this;
        }
    }
}
