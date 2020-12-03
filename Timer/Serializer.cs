using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Timer
{
    class Serializer
    {
        public List<DateTime> selectedDates { get; set; }
        public List<Entity> readedEntities { get; private set; }
        public List<Entity> readEntities { get; private set; }
        public List<Entity> entities;
        private string logName = DateTime.Now.ToString("dd''.''MM''.''yyyy");

        public Serializer(List<Entity> _entites)
        {
            entities = _entites;
        }

        public Serializer()
        {
            
        }

        public void Write()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Entity>));
            using (var fs = new FileStream(logName + ".xml", FileMode.Append))
            {
                xml.Serialize(fs, entities);
            }
        }

        public void Read()
        {
            foreach (var date in selectedDates)
            {
                var dateString = date.ToString("dd''.''MM''.''yyyy");

                XmlSerializer xml = new XmlSerializer(typeof(List<Entity>));

                using (var fs = new FileStream(dateString + ".xml", FileMode.Open))
                {
                    List<Entity> readEntities = (List<Entity>)xml.Deserialize(fs);
                }

                readedEntities.AddRange(readEntities);
            }
        }
    }
}
