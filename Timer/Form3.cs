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
    public partial class Form3 : Form
    {
        public bool activity = true;
        public Form3()
        {
            InitializeComponent();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
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
