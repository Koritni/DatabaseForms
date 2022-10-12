
namespace WindowsFormsApp1
{
    partial class Form_AddUpd_CategoryItem
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
            this.Button_Add_CategoryItem = new System.Windows.Forms.Button();
            this.TextBox_Category = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название категории";
            // 
            // Button_Add_CategoryItem
            // 
            this.Button_Add_CategoryItem.Location = new System.Drawing.Point(144, 298);
            this.Button_Add_CategoryItem.Name = "Button_Add_CategoryItem";
            this.Button_Add_CategoryItem.Size = new System.Drawing.Size(75, 23);
            this.Button_Add_CategoryItem.TabIndex = 7;
            this.Button_Add_CategoryItem.Text = "Добавить";
            this.Button_Add_CategoryItem.UseVisualStyleBackColor = true;
            this.Button_Add_CategoryItem.Click += new System.EventHandler(this.Button_Add_CategoryItem_Click);
            // 
            // TextBox_Category
            // 
            this.TextBox_Category.Location = new System.Drawing.Point(144, 151);
            this.TextBox_Category.Name = "TextBox_Category";
            this.TextBox_Category.Size = new System.Drawing.Size(118, 20);
            this.TextBox_Category.TabIndex = 6;
            // 
            // Form_AddUpd_CategoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Add_CategoryItem);
            this.Controls.Add(this.TextBox_Category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddUpd_CategoryItem";
            this.Text = "Form_Add_CategoryItem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddUpd_CategoryItem_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Add_CategoryItem;
        private System.Windows.Forms.TextBox TextBox_Category;
    }
}