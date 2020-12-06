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
        private string programName = "Timer";
        private string selectedCategory;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var loadSerialization = new Serializer();
                var dateNow = new List<DateTime>();
                dateNow.Add(DateTime.Now);
                entities = loadSerialization.ReadEntities(dateNow); 
            }
            catch (FileNotFoundException)
            {

            }

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
            StartButton.Enabled = false;
            PauseButton.Enabled = false;
            StopWorkButton.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer lastSession = new Serializer(entities, DateTime.Now.ToString("dd''.''MM''.''yyyy"));
            lastSession.Write();
            
            running = false;
            aw.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            StartButton.Enabled = false;
            PauseButton.Enabled = true;
            StopWorkButton.Enabled = true;
            categoriesBox.Enabled = false;
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
            entity.category = selectedCategory;
            entities.Add(entity);

            StopWorkButton.Enabled = false;
            PauseButton.Enabled = false;
            StartButton.Enabled = true;
            categoriesBox.Enabled = true;

            stopwatch.Reset();
        }

        private void ForegroundChanged(string name)
        {
            if (stopwatch.Running == true)
            {
                stopwatch.Pause();
                var entity = new Entity();
                entity.stopDate = DateTime.Now;
                entity.timeSpanTicks = stopwatch.programElapsed.Ticks/10000000;
                entity.programName = programName;
                entity.category = selectedCategory;
                entities.Add(entity);
                stopwatch.ResetProgramElapsed();
                stopwatch.Start();

                ActiveWindowLabel.Invoke((MethodInvoker)delegate
                {
                    ActiveWindowLabel.Text = programName;
                });
            }
            programName = name;

        }

        private void NewForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = categoriesBox.Text;

            if (selectedCategory == "Добавить категорию")
            {
                Form3 form = new Form3();
                form.Owner = this;
                form.ShowDialog();
            }

            selectedCategory = categoriesBox.SelectedItem.ToString();
            StartButton.Enabled = true;
        }
    }
}