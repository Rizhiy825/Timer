using System;
using System.IO;
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
    public partial class Form2 : Form
    {
        string[] filesName = Directory.GetFiles(@"C:\Users\User\source\repos\Rizhiy825\Timer\Timer\bin\Release", "*.xml");

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            DateTime[] dates = new DateTime[filesName.Length];

            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = DateTime.Parse(Path.GetFileNameWithoutExtension(filesName[i]));
            }

            Calendar.BoldedDates = dates;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
