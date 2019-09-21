using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitt.Pipeline
{
    public interface IPipeline
    {
        void Execute(object input);
        event Action<object> Finished;
    }
}
