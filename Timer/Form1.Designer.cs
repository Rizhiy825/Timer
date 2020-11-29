﻿namespace Timer
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
            this.label2 = new System.Windows.Forms.Label();
            this.ActiveWindowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultLabel.Location = new System.Drawing.Point(65, 21);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(200, 46);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Жми старт";
            // 
            // StopWorkButton
            // 
            this.StopWorkButton.AutoSize = true;
            this.StopWorkButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopWorkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopWorkButton.Location = new System.Drawing.Point(25, 89);
            this.StopWorkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StopWorkButton.Name = "StopWorkButton";
            this.StopWorkButton.Size = new System.Drawing.Size(79, 32);
            this.StopWorkButton.TabIndex = 1;
            this.StopWorkButton.Text = "Стоп";
            this.StopWorkButton.UseVisualStyleBackColor = true;
            this.StopWorkButton.Click += new System.EventHandler(this.StopWorkButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(221, 89);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(81, 32);
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
            this.DateSelectedLabel.Location = new System.Drawing.Point(166, 327);
            this.DateSelectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateSelectedLabel.Name = "DateSelectedLabel";
            this.DateSelectedLabel.Size = new System.Drawing.Size(113, 22);
            this.DateSelectedLabel.TabIndex = 4;
            this.DateSelectedLabel.Text = "выбери дату";
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSize = true;
            this.PauseButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.Location = new System.Drawing.Point(122, 89);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(81, 32);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Calendar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calendar.Location = new System.Drawing.Point(92, 141);
            this.Calendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
            this.label1.Location = new System.Drawing.Point(70, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Активное окно:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveWindowLabel
            // 
            this.ActiveWindowLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.ActiveWindowLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ActiveWindowLabel.Location = new System.Drawing.Point(11, 387);
            this.ActiveWindowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActiveWindowLabel.Name = "ActiveWindowLabel";
            this.ActiveWindowLabel.Size = new System.Drawing.Size(308, 22);
            this.ActiveWindowLabel.TabIndex = 9;
            this.ActiveWindowLabel.Text = "<не выбрано>";
            this.ActiveWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(330, 459);
            this.Controls.Add(this.ActiveWindowLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.DateSelectedLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopWorkButton);
            this.Controls.Add(this.ResultLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ActiveWindowLabel;
    }
}

