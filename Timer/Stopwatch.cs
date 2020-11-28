using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Stopwatch
    {
        public bool Running { get; private set; }
        public TimeSpan Elapsed
        {
            get
            {
                if (Running)
                {
                    return elapsed + SinceLastStart();
                }
                else
                {
                    return elapsed;
                }
            }
        }

        private DateTime startTime;
        private TimeSpan elapsed;

        public Stopwatch()
        {
            Reset();
        }

        public void Start()
        {
            Running = true;
            startTime = DateTime.Now;
        }

        public void Pause()
        {
            Running = false;
            elapsed += SinceLastStart();
        }

        public void Reset()
        {
            Running = false;
            startTime = new DateTime();
            elapsed = TimeSpan.Zero;
        }

        private TimeSpan SinceLastStart()
        {
            return DateTime.Now - startTime;
        }
    }
}
