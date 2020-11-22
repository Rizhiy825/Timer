using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Entity
    {
        public DateTime startDate { get; set; }
        public DateTime stopDate { get; private set; }
        public DateTime pauseDate { get; private set; }
        public TimeSpan timeSpan { get; set; }
        
        public Entity (DateTime start)
        {
            startDate = start;
            pauseDate = start;
        }

        public void Pause()
        {
            stopDate = DateTime.Now;
            timeSpan += stopDate.Subtract(startDate);
        }

        public void Stop()
        {
            stopDate = DateTime.Now;
            timeSpan += stopDate.Subtract(startDate);
            TxtWriter.Writer(timeSpan);
            
        }


    }
}
