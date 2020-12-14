
namespace Timer
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.Table = new System.Windows.Forms.DataGridView();
            this.categoryStatistic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(84, 30);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Date,
            this.programName,
            this.sessionTime,
            this.sessionStart,
            this.sessionStop});
            this.Table.Location = new System.Drawing.Point(29, 278);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 53;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(890, 271);
            this.Table.TabIndex = 1;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryStatistic
            // 
            this.categoryStatistic.FormattingEnabled = true;
            this.categoryStatistic.Location = new System.Drawing.Point(604, 129);
            this.categoryStatistic.Name = "categoryStatistic";
            this.categoryStatistic.Size = new System.Drawing.Size(276, 24);
            this.categoryStatistic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(352, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбери категорию:";
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 7;
            this.Date.Name = "Date";
            // 
            // programName
            // 
            this.programName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.programName.HeaderText = "Название программы";
            this.programName.MinimumWidth = 7;
            this.programName.Name = "programName";
            // 
            // sessionTime
            // 
            this.sessionTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionTime.HeaderText = "Время сессии";
            this.sessionTime.MinimumWidth = 7;
            this.sessionTime.Name = "sessionTime";
            // 
            // sessionStart
            // 
            this.sessionStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionStart.HeaderText = "Время начала сессии";
            this.sessionStart.MinimumWidth = 7;
            this.sessionStart.Name = "sessionStart";
            // 
            // sessionStop
            // 
            this.sessionStop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionStop.HeaderText = "Время окончания сессии";
            this.sessionStop.MinimumWidth = 7;
            this.sessionStop.Name = "sessionStop";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryStatistic);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Calendar);
            this.Name = "StatisticForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ComboBox categoryStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn programName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionStop;
    }
}