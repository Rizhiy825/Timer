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
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                foreach (var category in main.categories)
                {
                    CategoriesBox.Items.Add(category);
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
                manager.DeleteCategory(selectedItem);

                main.categoriesBox.Items.Remove(selectedItem);
                main.categories.Remove(selectedItem);
                Close();
            }
        }

    }
}
