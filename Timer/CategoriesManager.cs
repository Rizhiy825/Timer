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
        public List<Categories> categoriesList;
        private string dateForm;
        private List<string> fileName;

        public CategoriesManager(string _dateForm, string _fileName)
        {
            categoriesList = new List<Categories>();
            dateForm = _dateForm;
            fileName = new List<string>() { _fileName };
        }

        public void ReadCategories()
        {
            var serializer = new Serializer<Categories>(categoriesList, fileName);
            categoriesList = serializer.ReadEntities();
        }

        private void WriteCategories()
        {
            var serializer = new Serializer<Categories>(categoriesList, fileName);
            serializer.Write();
        }

        public void AddCategory(string newCategoryName)
        {
            this.ReadCategories();

            var newCategory = new Categories(newCategoryName);
            categoriesList.Add(newCategory);
            this.WriteCategories();
        }

        public void DeleteCategory(string deleteCategoryName)
        {
            this.ReadCategories();
            var deleteCategory = new Categories(deleteCategoryName);

            foreach (var category in categoriesList)
            {
                if (category.categoryName == deleteCategory.categoryName)
                {
                    categoriesList.Remove(category);
                    break;
                }

            }
            this.WriteCategories();
        }
    }
}
