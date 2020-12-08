using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    [Serializable]
    public class Categories
    {
        public string categoryName { get; set; }

        public Categories(string name)
        {
            categoryName = name;
        }

        public Categories()
        {

        }

    }
}
