using System;
using System.Threading;

namespace Clocks
{
    public class Clock
    { 
        private bool isWork;

        public Clock() { }

        public event EventHandler<RingEventArgs> Ring;

        public void Set(TimeSpan time, string message = "\nDzin-dzin-dzin!!!")
        {
            Start(time);
            OnRing(new RingEventArgs(time, message));
        }

        public static void ClockRing(object sender, RingEventArgs e)
        {
            Console.WriteLine($"The timer for {e._time.ToString()} is gone. {e._message}");
        }

        private void Start(TimeSpan time)
        {
            isWork = true;

            int timer = time.Seconds;
            Thread.Sleep(timer);

            isWork = false;
        }
        protected virtual void OnRing(RingEventArgs ringEventArgs)
        {
            Ring?.Invoke(this, ringEventArgs);
        }
    }
}
