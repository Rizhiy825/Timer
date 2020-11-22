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
    
    public partial class Form1 : Form
    {

        public DateTime selectedDate { get; set; }
        Entity entity = new Entity(DateTime.Now);
        public Form1()
        {
            InitializeComponent();
            StopWorkButton.Enabled = false;
            var dateList = TxtWriter.Checker();

            foreach (var date in dateList)
            {
                Calendar.AddBoldedDate(date);
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            entity.startDate = DateTime.Now;
            StopWorkButton.Enabled = true;
            
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            entity.Pause();
            ResultLable.Text = entity.timeSpan.ToString("hh':'mm':'ss");
        }

        private void StopWorkButton_Click(object sender, EventArgs e)
        {
            entity.Stop();
            ResultLable.Text = entity.timeSpan.ToString("hh':'mm':'ss");
            entity.timeSpan = TimeSpan.Zero;
            StopWorkButton.Enabled = false;
            Calendar.AddBoldedDate(entity.stopDate);
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var selectedDate = Calendar.SelectionStart.Date;
            selectedDate = TxtWriter.Reader(selectedDate);
            DateSelectedLabel.Text = selectedDate.ToString("HH':'mm':'ss");
        }

    }
}
