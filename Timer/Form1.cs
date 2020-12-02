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
        private Stopwatch stopwatch = new Stopwatch();
        private bool running = true;
        private List<Entity> entities = new List<Entity>();
        private ActiveWindow aw;
        private string programName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Serializer lastSession = new Serializer(entities);
            lastSession.Read();


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
            Serializer lastSession = new Serializer(entities);
            lastSession.Write();
            
            running = false;
            aw.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            StartButton.Enabled = false;
            StopWorkButton.Enabled = true;
            PauseButton.Enabled = true;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            stopwatch.Pause();
            PauseButton.Enabled = false;
            StartButton.Enabled = true;
            StopWorkButton.Enabled = true;
        }

        private void StopWorkButton_Click(object sender, EventArgs e)
        {
            stopwatch.Pause();
            var entity = new Entity();
            entity.stopDate = DateTime.Now;
            entity.timeSpanTicks = stopwatch.programElapsed.Ticks/10000000;
            entity.programName = programName;
            entities.Add(entity);

            StopWorkButton.Enabled = false;
            PauseButton.Enabled = false;
            StartButton.Enabled = true;

            stopwatch.Reset();
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var selectedDate = Calendar.SelectionStart.Date;
            DateSelectedLabel.Text = selectedDate.ToString("HH':'mm':'ss");
        }


        private void ForegroundChanged(string name)
        {
            programName = name;

            if (stopwatch.Running == true)
            {
                stopwatch.Pause();
                var entity = new Entity();
                entity.stopDate = DateTime.Now;
                entity.timeSpanTicks = stopwatch.programElapsed.Ticks/10000000;
                entity.programName = name;
                entities.Add(entity);
                stopwatch.ResetProgramElapsed();
                stopwatch.Start();

                ActiveWindowLabel.Invoke((MethodInvoker)delegate
                {
                    ActiveWindowLabel.Text = programName;
                });
                

            }
        }
    }
}