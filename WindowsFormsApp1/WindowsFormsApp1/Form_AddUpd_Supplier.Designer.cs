
namespace WindowsFormsApp1
{
    partial class Form_AddUpd_Supplier
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
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Date_Contract = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Adress = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(134, 38);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Name.TabIndex = 0;
            // 
            // Date_Contract
            // 
            this.Date_Contract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Contract.Location = new System.Drawing.Point(134, 79);
            this.Date_Contract.Name = "Date_Contract";
            this.Date_Contract.Size = new System.Drawing.Size(100, 20);
            this.Date_Contract.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата контракта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес";
            // 
            // TextBox_Adress
            // 
            this.TextBox_Adress.Location = new System.Drawing.Point(134, 119);
            this.TextBox_Adress.Name = "TextBox_Adress";
            this.TextBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Adress.TabIndex = 4;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(134, 301);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 6;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Form_AddUpd_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Adress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_Contract);
            this.Controls.Add(this.TextBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddUpd_Supplier";
            this.Text = "Добавить запись";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddUpd_Supplier_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.DateTimePicker Date_Contract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Adress;
        private System.Windows.Forms.Button Button_Add;
    }
}