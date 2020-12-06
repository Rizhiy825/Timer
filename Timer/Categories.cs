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
    class Categories
    {
        private List<string> categoriesList { get; set; }
        private string fileName = "Categories";
        private string categoryName { get; set; }


        public Categories(string category)
        {
            categoryName = category;
        }
    }
}
