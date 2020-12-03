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
        private string logName = DateTime.Now.ToString("dd''.''MM''.''yyyy");
        public List<Entity> entities;
        public List<Entity> readEntities { get; set; }
        

        public Serializer(List<Entity> _entites)
        {
            entities = _entites;
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
            XmlSerializer xml = new XmlSerializer(typeof(List<Entity>));

            using (var fs = new FileStream(logName + ".xml", FileMode.OpenOrCreate))
            {
                List<Entity> readEntities = (List<Entity>)xml.Deserialize(fs);
            }
        }

        
    }
}
