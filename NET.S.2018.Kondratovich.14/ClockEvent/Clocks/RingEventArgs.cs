using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    public class RingEventArgs
    {
        public readonly TimeSpan _time;
        public readonly string _message;

        public RingEventArgs(TimeSpan time, string message)
        {
            _time = time;
            _message = message;
        }
    }
}
