using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Statistics
    {
        public List<Entity> readEntities { get; set; }
        public Statistics(List<Entity> entities)
        {
            readEntities = entities;

        }



    }
}
