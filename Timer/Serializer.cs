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
    class Serializer
    {
        public List<DateTime> selectedDates { get; set; }
        public List<Entity> readedEntities { get; private set; }
        public string fileName { get; set; }
        public List<Entity> entities;

        public Serializer(List<Entity> _entites, string _fileName)
        {
            entities = _entites;
            fileName = _fileName;
        }

        public Serializer()
        {
            selectedDates = new List<DateTime>();
            readedEntities = new List<Entity>();
            entities = new List<Entity>();
        }

        public void Write()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Entity>));
            using (var fs = new FileStream(fileName + ".xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, entities);
            }
        }



        public List<Entity> ReadEntities(List<DateTime> datesList)
        {

            foreach (var date in datesList)
            {
                var dateString = date.ToString("dd''.''MM''.''yyyy");

                XmlSerializer xml = new XmlSerializer(typeof(List<Entity>));

                using (var fs = new FileStream(dateString + ".xml", FileMode.Open))
                {
                    List<Entity> readEntities = (List<Entity>)xml.Deserialize(fs);
                    readedEntities.AddRange(readEntities);
                    selectedDates.Add(date);
                }
            }
            return readedEntities;
        }
    }
}
