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
            categoryStatistic.Enabled = false;
            /*Form1 main = this.Owner as Form1;
            if (main != null)
            {
                foreach (var category in main.categoriesList)
                {
                    if (category.categoryName != main.addCat || category.categoryName != main.delCat)
                    {
                        categoryStatistic.Items.Add(category.categoryName);
                    }
                }
            }*/

            DateTime[] dates = new DateTime[filesName.Length];

            for (int i = 0; i < dates.Length; i++)
            {
                try
                {
                    dates[i] = DateTime.Parse(Path.GetFileNameWithoutExtension(filesName[i]));
                    boldedDates.Add(dates[i]);
                }
                catch (FormatException)
                {

                }
            }

            Calendar.BoldedDates = dates;
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            categoryStatistic.Enabled = true;
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                Table.Rows.Clear();
                categoryStatistic.Items.Clear();
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

                datesList.Clear();
                var serializer = new Serializer<Session>(main.sessions, fullDates);
                var sessions = serializer.ReadEntities();
                List<String> categoryCellList = new List<String>();

                foreach (var session in sessions)
                {
                    Table.Rows.Add(session.category,
                        session.stopDate.ToString(main.dateForm),
                        session.programName,
                        TimeSpan.FromTicks(session.timeSpanTicks).ToString(@"hh\:mm\:ss"),
                        session.stopDate - TimeSpan.FromTicks(session.timeSpanTicks),
                        session.stopDate);


                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        var p = Table[0, i].Value;

                        if (p != null)
                        {
                            categoryCellList.Add(p.ToString());
                        }
                    }

                }

                var distCategory = categoryCellList.Distinct();
                foreach (var cat in distCategory)
                {
                    categoryStatistic.Items.Add(cat);
                }

                fullDates.Clear();

            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table.Rows.Clear();
        }

        private void categoryStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCat = categoryStatistic.SelectedItem.ToString();
            TimeSpan sum = new TimeSpan() ;

            for (int i = 0; i < Table.Rows.Count - 1; i++)
            {
                try
                {
                    if (Table[0, i].Value.ToString() == selectedCat)
                    {
                        var time = TimeSpan.Parse(Table[3, i].Value.ToString());
                        sum = sum.Add(time);
                    }

                }
                catch (NullReferenceException)
                {

                }
            }

            SumResultLabel.Text = sum.ToString(@"hh\:mm\:ss");
        }
    }
}
