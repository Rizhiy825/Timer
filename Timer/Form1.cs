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
        public List<Session> sessions = new List<Session>();
        public List<Categories> categoriesList = new List<Categories>();
        private ActiveWindow aw;
        private string programName = "Timer";
        public string categoriesFileName = "Categories";
        private string selectedCategory;
        public string dateForm = "dd''.''MM''.''yyyy";
        public string addCat = "Добавить категорию";
        public string delCat = "Удалить категорию";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var dateNow = new List<string>() { DateTime.Now.ToString(dateForm) };
                var loadSessionsSerialization = new Serializer<Session>(sessions, dateNow);
                sessions = loadSessionsSerialization.ReadEntities();
            }
            catch (FileNotFoundException)
            {

            }

            try
            {
                var categories = new CategoriesManager(dateForm, categoriesFileName);
                categories.ReadCategories();

                foreach (var category in categories.categoriesList)
                {
                    categoriesList.Add(category);
                    categoriesBox.Items.Add(category.categoryName);
                }
            }
            catch (FileNotFoundException)
            {

            }

            categoriesBox.Items.Add(addCat);
            categoriesBox.Items.Add(delCat);

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
            var dateNow = new List<string>() { DateTime.Now.ToString(dateForm) };
            Serializer<Session> lastSession = new Serializer<Session>(sessions, dateNow);
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
            var session = new Session();
            session.stopDate = DateTime.Now;
            session.timeSpanTicks = stopwatch.programElapsed.Ticks/10000000;
            session.programName = programName;
            session.category = selectedCategory;
            sessions.Add(session);

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
                var entity = new Session();
                entity.stopDate = DateTime.Now;
                entity.timeSpanTicks = stopwatch.programElapsed.Ticks/10000000;
                entity.programName = programName;
                entity.category = selectedCategory;
                sessions.Add(entity);
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
            StatisticForm form = new StatisticForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = categoriesBox.Text;

            if (selectedCategory == addCat)
            {
                AddCategoryForm form = new AddCategoryForm();
                form.Owner = this;
                form.ShowDialog();

            }
            else if (selectedCategory == delCat)
            {
                DeleteCategoryForm form = new DeleteCategoryForm();
                form.Owner = this;
                form.ShowDialog();
            }

            if (selectedCategory == "" || selectedCategory == addCat || selectedCategory == delCat)
            {
                StartButton.Enabled = false;
            }
            else
            {
                StartButton.Enabled = true;
            }
        }
    }
}