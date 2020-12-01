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
using System.Xml.Serialization;

namespace Timer
{

    public partial class Form1 : Form
    {

        private DateTime selectedDate { get; set; }
        private DateTime startDate;
        private Stopwatch stopwatch = new Stopwatch();
        private bool running = true;
        private List<Entity> entities = new List<Entity>();
        private ActiveWindow aw;
        private string programName;
        private Entity entity = new Entity();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopWorkButton.Enabled = false;

            Task.Factory.StartNew(async () =>
            {
                while (running)
                {
                    if (stopwatch.Running)
                    {
                        ResultLabel.Invoke((MethodInvoker)delegate
                        {
                            ResultLabel.Text = stopwatch.Elapsed.ToString("hh':'mm':'ss");
                        });

                        await Task.Delay(50);
                    }
                    else
                    {
                        await Task.Delay(500);
                    }
                }
            });

            aw = new ActiveWindow(ForegroundChanged);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
            aw.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            startDate = DateTime.Now;
            entity.startDate = startDate;
            entity.programName = programName;

            StartButton.Enabled = false;
            StopWorkButton.Enabled = true;
            PauseButton.Enabled = true;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            stopwatch.Pause();
            // entity.Pause();
            // ResultLabel.Text = entity.timeSpan.ToString("hh':'mm':'ss");
            PauseButton.Enabled = false;
            StartButton.Enabled = true;
        }

        private void StopWorkButton_Click(object sender, EventArgs e)
        {
            stopwatch.Pause();

            var stopDate = DateTime.Now;
            var elapsed = stopwatch.Elapsed;
            entity.timeSpan = stopwatch.Elapsed;
            entity.stopDate = DateTime.Now;
            entities.Add(entity);
            Write();

            StopWorkButton.Enabled = false;
            Calendar.AddBoldedDate(stopDate);

            stopwatch.Reset();
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var selectedDate = Calendar.SelectionStart.Date;
            selectedDate = TxtWriter.Reader(selectedDate);
            DateSelectedLabel.Text = selectedDate.ToString("HH':'mm':'ss");
        }

        private void Write()
        {
            var xml = new XmlSerializer(typeof(List<Entity>));

            using (var fs = new FileStream("Logs.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, entities);
            }
            entity.startDate = DateTime.MinValue;
            entity.stopDate = DateTime.MinValue;
            entity.timeSpan = TimeSpan.Zero;
        }


        private void ForegroundChanged(string name)
        {
            programName = name;

            if (stopwatch.Running == true)
            {
                ActiveWindowLabel.Invoke((MethodInvoker)delegate
                {
                    ActiveWindowLabel.Text = programName;
                });
            }
        }
    }
}