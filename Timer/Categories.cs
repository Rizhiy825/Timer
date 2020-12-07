using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Timer
{
    [Serializable]
    public class Categories
    {

        public string fileName = "Categories";
        public string categoryName { get; set; }


        public Categories(string category)
        {
            categoryName = category;
        }

        public Categories()
        {

        }
    }
}
