
namespace WindowsFormsApp1
{
    partial class Form_AddUpd_TradeMark
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
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.Button_Add_Trademark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Telephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Location = new System.Drawing.Point(134, 117);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(118, 48);
            this.TextBox_Description.TabIndex = 0;
            // 
            // Button_Add_Trademark
            // 
            this.Button_Add_Trademark.Location = new System.Drawing.Point(134, 301);
            this.Button_Add_Trademark.Name = "Button_Add_Trademark";
            this.Button_Add_Trademark.Size = new System.Drawing.Size(75, 23);
            this.Button_Add_Trademark.TabIndex = 1;
            this.Button_Add_Trademark.Text = "Добавить";
            this.Button_Add_Trademark.UseVisualStyleBackColor = true;
            this.Button_Add_Trademark.Click += new System.EventHandler(this.Button_Add_Trademark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(134, 76);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(118, 20);
            this.TextBox_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // TextBox_Telephone
            // 
            this.TextBox_Telephone.Location = new System.Drawing.Point(134, 182);
            this.TextBox_Telephone.Name = "TextBox_Telephone";
            this.TextBox_Telephone.Size = new System.Drawing.Size(118, 20);
            this.TextBox_Telephone.TabIndex = 5;
            this.TextBox_Telephone.TextChanged += new System.EventHandler(this.TextBox_Telephone_TextChanged);
            this.TextBox_Telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Telephone_KeyPress);
            // 
            // Form_AddUpd_TradeMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Telephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Add_Trademark);
            this.Controls.Add(this.TextBox_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddUpd_TradeMark";
            this.Text = "Form_Add_TradeMark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddUpd_TradeMark_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Button Button_Add_Trademark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Telephone;
    }
}