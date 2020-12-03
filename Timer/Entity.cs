using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    [Serializable]
    public class Entity
    {
        public DateTime stopDate { get; set; }
        public long timeSpanTicks { get; set; }
        public string programName { get; set; }
        

        public Entity()
        {

        }

        public Entity(DateTime stop, long span, string progName)
        {
            stopDate = stop;
            timeSpanTicks = span;
            programName = progName;
        }

        public void Clean()
        {
            stopDate = DateTime.MinValue;
            timeSpanTicks = 0;


        }
    }
}
