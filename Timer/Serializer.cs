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
        public List<string> selectedFiles { get; set; }
        public List<Type> readedFilesEntity { get; private set; }
        public string fileName { get; set; }
        public List<Type> entities;

        public Serializer(List<Type> _entites, List<string> fileNameList)
        {
            entities = _entites;
            selectedFiles = fileNameList;
            readedFilesEntity = new List<Type>();
        }

        public void Write()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Type>));
            var fileName = selectedFiles.Last();
            using (var fs = new FileStream(fileName + ".xml", FileMode.Create))
            {
                xml.Serialize(fs, entities);
            }
            
        }

        public List<Type> ReadEntities()
        {
            foreach (var file in selectedFiles)
            {

                XmlSerializer xml = new XmlSerializer(typeof(List<Type>));

                using (var fs = new FileStream(file + ".xml", FileMode.Open))
                {
                    try
                    {
                        List<Type> readFile = (List<Type>)xml.Deserialize(fs);
                        readedFilesEntity.AddRange(readFile);
                    }
                    catch (InvalidOperationException)
                    {

                    }
                    
                }
            }
            return readedFilesEntity;
        }
    }
}
