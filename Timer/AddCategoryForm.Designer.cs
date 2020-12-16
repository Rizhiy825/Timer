
namespace Timer
{
    partial class AddCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCategoryTextBox = new System.Windows.Forms.TextBox();
            this.ChangeCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление категории";
            // 
            // addCategoryTextBox
            // 
            this.addCategoryTextBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.addCategoryTextBox.Location = new System.Drawing.Point(74, 131);
            this.addCategoryTextBox.Name = "addCategoryTextBox";
            this.addCategoryTextBox.Size = new System.Drawing.Size(214, 37);
            this.addCategoryTextBox.TabIndex = 1;
            this.addCategoryTextBox.Text = "Введите название";
            // 
            // ChangeCategoryButton
            // 
            this.ChangeCategoryButton.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.ChangeCategoryButton.Location = new System.Drawing.Point(333, 131);
            this.ChangeCategoryButton.Name = "ChangeCategoryButton";
            this.ChangeCategoryButton.Size = new System.Drawing.Size(245, 37);
            this.ChangeCategoryButton.TabIndex = 2;
            this.ChangeCategoryButton.Text = "Добавить";
            this.ChangeCategoryButton.UseVisualStyleBackColor = true;
            this.ChangeCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(645, 199);
            this.Controls.Add(this.ChangeCategoryButton);
            this.Controls.Add(this.addCategoryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddCategoryForm";
            this.Text = "Добавление занятия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeCategoryButton;
        public System.Windows.Forms.TextBox addCategoryTextBox;
    }
}