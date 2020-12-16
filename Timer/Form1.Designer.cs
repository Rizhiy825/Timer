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
            this.PauseButton = new System.Windows.Forms.Button();
            this.ActiveWindowLabel = new System.Windows.Forms.Label();
            this.NewForm2 = new System.Windows.Forms.Button();
            this.categoriesBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ResultLabel.Location = new System.Drawing.Point(132, 36);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(217, 61);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "00:00:00";
            // 
            // StopWorkButton
            // 
            this.StopWorkButton.AutoSize = true;
            this.StopWorkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopWorkButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopWorkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopWorkButton.Location = new System.Drawing.Point(42, 191);
            this.StopWorkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopWorkButton.Name = "StopWorkButton";
            this.StopWorkButton.Size = new System.Drawing.Size(105, 41);
            this.StopWorkButton.TabIndex = 1;
            this.StopWorkButton.Text = "Стоп";
            this.StopWorkButton.UseVisualStyleBackColor = true;
            this.StopWorkButton.Click += new System.EventHandler(this.StopWorkButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(304, 191);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 41);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSize = true;
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.Location = new System.Drawing.Point(172, 191);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(108, 41);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ActiveWindowLabel
            // 
            this.ActiveWindowLabel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.ActiveWindowLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ActiveWindowLabel.Location = new System.Drawing.Point(12, 356);
            this.ActiveWindowLabel.Name = "ActiveWindowLabel";
            this.ActiveWindowLabel.Size = new System.Drawing.Size(411, 80);
            this.ActiveWindowLabel.TabIndex = 9;
            this.ActiveWindowLabel.Text = "<не выбрано>";
            this.ActiveWindowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActiveWindowLabel.Visible = false;
            // 
            // NewForm2
            // 
            this.NewForm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewForm2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.NewForm2.Location = new System.Drawing.Point(143, 266);
            this.NewForm2.Name = "NewForm2";
            this.NewForm2.Size = new System.Drawing.Size(161, 44);
            this.NewForm2.TabIndex = 10;
            this.NewForm2.Text = "Статистика";
            this.NewForm2.UseVisualStyleBackColor = true;
            this.NewForm2.Click += new System.EventHandler(this.NewForm2_Click);
            // 
            // categoriesBox
            // 
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.Location = new System.Drawing.Point(245, 137);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(181, 24);
            this.categoriesBox.TabIndex = 11;
            this.categoriesBox.SelectedIndexChanged += new System.EventHandler(this.categoriesBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Вид деятельности:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoriesBox);
            this.Controls.Add(this.NewForm2);
            this.Controls.Add(this.ActiveWindowLabel);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopWorkButton);
            this.Controls.Add(this.ResultLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label ActiveWindowLabel;
        private System.Windows.Forms.Button NewForm2;
        public System.Windows.Forms.ComboBox categoriesBox;
        private System.Windows.Forms.Label label1;
    }
}

