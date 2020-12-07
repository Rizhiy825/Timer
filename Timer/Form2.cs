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
        string[] filesName = Directory.GetFiles(@".\", "*.xml");
        List<DateTime> boldedDates = new List<DateTime>();
        List<string> fullDates = new List<string>();

        public string dateForm = "dd''.''MM''.''yyyy";

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
                boldedDates.Add(dates[i]);
            }

            Calendar.BoldedDates = dates;
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            Table.Rows.Clear();
            SelectionRange selectedRange = Calendar.SelectionRange;
            List<DateTime> datesList = new List<DateTime>();
            TimeSpan datesDif = selectedRange.End - selectedRange.Start;
           
            datesList.Add(selectedRange.Start);

            for (int i = 0; i < datesDif.Days; i++)
            {
                datesList.Add(selectedRange.Start.AddDays(1));
            }

            foreach (var date in datesList)
            {
                for (int i = 0; i < boldedDates.Count; i++)
                {
                    if (date == boldedDates[i])
                    {
                        fullDates.Add(date.ToString(dateForm));
                    }
                }
            }

            var serializer = new Serializer<Entity>();
            var entities = serializer.ReadEntities(fullDates);

            foreach (var entity in entities)
            {
                Table.Rows.Add(entity.stopDate.ToString(dateForm),
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
