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
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectionRange selectedRange = Calendar.SelectionRange;   /*.ToString("dd''.''MM''.''yyyy");*/
            List<DateTime> datesList = new List<DateTime>();
            TimeSpan datesDif = selectedRange.End - selectedRange.Start;
           
            datesList.Add(selectedRange.Start);

            for (int i = 0; i < datesDif.Days; i++)
            {
                datesList.Add(selectedRange.Start.AddDays(1));
            }

            var serializer = new Serializer();
            serializer.selectedDates = datesList;
            serializer.Read();

            foreach (var entity in serializer.readedEntities)
            {
                Table.Rows.Add(entity.stopDate.ToString("dd''.''MM''.'yyyy"),
                    entity.programName, 
                    entity.timeSpanTicks, 
                    entity.stopDate - TimeSpan.FromTicks(entity.timeSpanTicks),
                    entity.stopDate);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
