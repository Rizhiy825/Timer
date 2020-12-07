using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form3 : Form
    {
        public bool activity = true;
        public Form3()
        {
            InitializeComponent();
        }

        public void addCategoryButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                var update = new Serializer<Categories>();
                var newCategory = new Categories(addCategoryTextBox.Text);
                List<string> fileName = new List<string>();
                fileName.Add(newCategory.fileName);

                List<Categories> categoriesList = new List<Categories>();
                

                try
                {
                    categoriesList = update.ReadEntities(fileName);
                }
                catch (FileNotFoundException)
                {

                }


                categoriesList.Add(newCategory);
                update.entities = categoriesList;
                update.fileName = newCategory.fileName;
                update.Write();

                main.categoriesBox.Items.Insert(0, addCategoryTextBox.Text);
                main.categoriesBox.SelectedIndex = 0;
                Close();
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
