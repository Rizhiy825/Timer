using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Statistics
    {
        public List<Session> readEntities { get; set; }
        public Statistics(List<Session> entities)
        {
            readEntities = entities;

        }



    }
}
