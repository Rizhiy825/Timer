﻿using System;
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
    public partial class AddCategoryForm : Form
    {
        public bool activity = true;
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        public void addCategoryButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                var manager = new CategoriesManager(main.dateForm, main.categoriesFileName);
                

                manager.AddCategory(addCategoryTextBox.Text);



                var newCategory = new Categories(addCategoryTextBox.Text);
                main.categoriesBox.Items.Insert(0, addCategoryTextBox.Text);
                main.categoriesBox.SelectedIndex = 0;
                main.categoriesList.Add(newCategory);
                Close();
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
