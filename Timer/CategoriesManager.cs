using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class CategoriesManager
    {
        public List<string> categoriesList;
        private string dateForm;
        private List<string> fileName;

        public CategoriesManager(string _dateForm, string _fileName)
        {
            categoriesList = new List<string>();
            dateForm = _dateForm;
            fileName = new List<string>() { _fileName };
        }

        private void ReadCategories()
        {
            var serializer = new Serializer<string>(categoriesList, fileName);
            categoriesList = serializer.ReadEntities();
        }

        private void WriteCategories()
        {
            var serializer = new Serializer<string>(categoriesList, fileName);
            serializer.Write();
        }

        public void AddCategory(string newCategoryName)
        {
            try
            {
                this.ReadCategories();
                
            }
            catch (FileNotFoundException)
            {

            }

            categoriesList.Add(newCategoryName);
            this.WriteCategories();
        }

        public void DeleteCategory(string deleteCategoryName)
        {
            this.ReadCategories();
            foreach (var category in categoriesList)
            {
                if (category == deleteCategoryName)
                {
                    categoriesList.Remove(category);
                    break;
                }

            }
            this.WriteCategories();
        }
    }
}
