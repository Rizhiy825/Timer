
namespace Timer
{
    partial class Form2
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
            this.Calendar.Location = new System.Drawing.Point(382, 50);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.programName,
            this.sessionTime,
            this.sessionStart,
            this.sessionStop});
            this.Table.Location = new System.Drawing.Point(147, 349);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 53;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(706, 145);
            this.Table.TabIndex = 1;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 7;
            this.Date.Name = "Date";
            this.Date.Width = 130;
            // 
            // programName
            // 
            this.programName.HeaderText = "Название программы";
            this.programName.MinimumWidth = 7;
            this.programName.Name = "programName";
            this.programName.Width = 130;
            // 
            // sessionTime
            // 
            this.sessionTime.HeaderText = "Время сессии";
            this.sessionTime.MinimumWidth = 7;
            this.sessionTime.Name = "sessionTime";
            this.sessionTime.Width = 130;
            // 
            // sessionStart
            // 
            this.sessionStart.HeaderText = "Время начала сессии";
            this.sessionStart.MinimumWidth = 7;
            this.sessionStart.Name = "sessionStart";
            this.sessionStart.Width = 130;
            // 
            // sessionStop
            // 
            this.sessionStop.HeaderText = "Время окончания сессии";
            this.sessionStop.MinimumWidth = 7;
            this.sessionStop.Name = "sessionStop";
            this.sessionStop.Width = 130;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 596);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Calendar);
            this.Name = "Form2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn programName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionStop;
    }
}