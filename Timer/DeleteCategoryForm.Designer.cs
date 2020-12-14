
namespace Timer
{
    partial class DeleteCategoryForm
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
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.CategoriesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label1.Location = new System.Drawing.Point(130, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Удаление категории";
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.DeleteCategoryButton.Location = new System.Drawing.Point(402, 206);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(245, 37);
            this.DeleteCategoryButton.TabIndex = 4;
            this.DeleteCategoryButton.Text = "Удалить";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // CategoriesBox
            // 
            this.CategoriesBox.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.CategoriesBox.FormattingEnabled = true;
            this.CategoriesBox.Location = new System.Drawing.Point(42, 206);
            this.CategoriesBox.Name = "CategoriesBox";
            this.CategoriesBox.Size = new System.Drawing.Size(314, 37);
            this.CategoriesBox.TabIndex = 5;
            this.CategoriesBox.Text = "Выбери категорию";
            this.CategoriesBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesBox_SelectedIndexChanged);
            // 
            // DeleteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 277);
            this.Controls.Add(this.CategoriesBox);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCategoryForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DeleteCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.ComboBox CategoriesBox;
    }
}