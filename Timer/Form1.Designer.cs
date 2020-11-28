namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultLabel = new System.Windows.Forms.Label();
            this.StopWorkButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.DateSelectedLabel = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLable
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultLabel.Location = new System.Drawing.Point(87, 26);
            this.ResultLabel.Name = "ResultLable";
            this.ResultLabel.Size = new System.Drawing.Size(255, 57);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Жми старт";
            // 
            // StopWorkButton
            // 
            this.StopWorkButton.AutoSize = true;
            this.StopWorkButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopWorkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopWorkButton.Location = new System.Drawing.Point(33, 109);
            this.StopWorkButton.Name = "StopWorkButton";
            this.StopWorkButton.Size = new System.Drawing.Size(105, 39);
            this.StopWorkButton.TabIndex = 1;
            this.StopWorkButton.Text = "Стоп";
            this.StopWorkButton.UseVisualStyleBackColor = true;
            this.StopWorkButton.Click += new System.EventHandler(this.StopWorkButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(295, 109);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 39);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DateSelectedLabel
            // 
            this.DateSelectedLabel.AutoSize = true;
            this.DateSelectedLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateSelectedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DateSelectedLabel.Location = new System.Drawing.Point(222, 402);
            this.DateSelectedLabel.Name = "DateSelectedLabel";
            this.DateSelectedLabel.Size = new System.Drawing.Size(145, 29);
            this.DateSelectedLabel.TabIndex = 4;
            this.DateSelectedLabel.Text = "выбери дату";
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSize = true;
            this.PauseButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.Location = new System.Drawing.Point(162, 109);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(108, 39);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Calendar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calendar.Location = new System.Drawing.Point(123, 174);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 6;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(93, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.DateSelectedLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopWorkButton);
            this.Controls.Add(this.ResultLabel);
            this.Name = "Form1";
            this.Text = "Work timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button StopWorkButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label DateSelectedLabel;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
    }
}

