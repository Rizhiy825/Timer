using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Timer
{
    class Serializer<Type>
    {
        public List<string> selectedDates { get; set; }
        public List<Type> readedEntities { get; private set; }
        public string fileName { get; set; }
        public List<Type> entities;
        public string dateForm = "dd''.''MM''.''yyyy"; //как передать этот параметр из форм1?

        public Serializer(List<Type> _entites, string _fileName)
        {
            entities = _entites;
            fileName = _fileName;
        }

        public Serializer()
        {
            selectedDates = new List<string>();
            readedEntities = new List<Type>();
            entities = new List<Type>();
        }

        public void Write()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Type>));
            using (var fs = new FileStream(fileName + ".xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, entities);
            }
        }



        public List<Type> ReadEntities(List<string> datesList)
        {

            foreach (var date in datesList)
            {

                XmlSerializer xml = new XmlSerializer(typeof(List<Type>));

                using (var fs = new FileStream(date + ".xml", FileMode.Open))
                {
                    List<Type> readEntities = (List<Type>)xml.Deserialize(fs);
                    readedEntities.AddRange(readEntities);
                    selectedDates.Add(date);
                }
            }
            return readedEntities;
        }
    }
}
