using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class DeleteCategoryForm : Form
    {
        public DeleteCategoryForm()
        {
            InitializeComponent();
        }
        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            DeleteCategoryButton.Enabled = false;
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                foreach (var category in main.categoriesList)
                {
                    CategoriesBox.Items.Add(category.categoryName);
                }
            }
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                var manager = new CategoriesManager(main.dateForm, main.categoriesFileName);
                var selectedItem = CategoriesBox.SelectedItem.ToString();
                var delCategory = new Categories(selectedItem);
                manager.DeleteCategory(delCategory);

                foreach (var category in main.categoriesList)
                {
                    if (selectedItem == category.categoryName)
                    {
                        main.categoriesList.Remove(category);
                        main.categoriesBox.Items.Remove(category.categoryName);

                        if (main.categoriesBox.Items.Count != 2)
                        {
                            main.categoriesBox.SelectedIndex = 0;
                        }
                        else
                        {
                            main.categoriesBox.SelectedIndex = -1;
                        }
                        break;
                    }
                }

                Close();
            }
        }

        private void CategoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteCategoryButton.Enabled = true;
        }
    }
}
