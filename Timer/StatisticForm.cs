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
    public partial class StatisticForm : Form
    {
        string[] filesName = Directory.GetFiles(@".\", "*.xml");
        List<DateTime> boldedDates = new List<DateTime>();
        List<string> fullDates = new List<string>();

        public StatisticForm()
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
            Form1 main = this.Owner as Form1;
            if (main != null)
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
                            fullDates.Add(date.ToString(main.dateForm));
                        }
                    }
                }

                var serializer = new Serializer<Session>(main.sessions, fullDates);
                var sessions = serializer.ReadEntities();

                foreach (var serssion in sessions)
                {
                    Table.Rows.Add(serssion.stopDate.ToString(main.dateForm),
                        serssion.programName,
                        serssion.timeSpanTicks,
                        serssion.stopDate - TimeSpan.FromTicks(serssion.timeSpanTicks),
                        serssion.stopDate);
                }
            }   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
