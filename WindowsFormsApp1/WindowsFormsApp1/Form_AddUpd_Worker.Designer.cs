
namespace WindowsFormsApp1
{
    partial class Form_AddUpd_Worker
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
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Patronymic = new System.Windows.Forms.TextBox();
            this.BirthdayDate = new System.Windows.Forms.DateTimePicker();
            this.Button_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_PassportNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_Money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Location = new System.Drawing.Point(140, 35);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_LastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(140, 74);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // TextBox_Patronymic
            // 
            this.TextBox_Patronymic.Location = new System.Drawing.Point(140, 109);
            this.TextBox_Patronymic.Name = "TextBox_Patronymic";
            this.TextBox_Patronymic.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Patronymic.TabIndex = 4;
            // 
            // BirthdayDate
            // 
            this.BirthdayDate.CustomFormat = "MM-dd-yyyy";
            this.BirthdayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDate.Location = new System.Drawing.Point(140, 146);
            this.BirthdayDate.MaxDate = new System.DateTime(2022, 4, 19, 0, 0, 0, 0);
            this.BirthdayDate.Name = "BirthdayDate";
            this.BirthdayDate.Size = new System.Drawing.Size(100, 20);
            this.BirthdayDate.TabIndex = 6;
            this.BirthdayDate.Value = new System.DateTime(2022, 4, 19, 0, 0, 0, 0);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(126, 301);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 7;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер паспорта";
            // 
            // TextBox_PassportNumber
            // 
            this.TextBox_PassportNumber.Location = new System.Drawing.Point(140, 182);
            this.TextBox_PassportNumber.Mask = "0000-000000";
            this.TextBox_PassportNumber.Name = "TextBox_PassportNumber";
            this.TextBox_PassportNumber.Size = new System.Drawing.Size(100, 20);
            this.TextBox_PassportNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Зарплата";
            // 
            // TextBox_Money
            // 
            this.TextBox_Money.Location = new System.Drawing.Point(140, 230);
            this.TextBox_Money.Name = "TextBox_Money";
            this.TextBox_Money.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Money.TabIndex = 12;
            this.TextBox_Money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Money_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Например: 123.12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Например: 1234-123456";
            // 
            // Form_AddUpd_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_Money);
            this.Controls.Add(this.TextBox_PassportNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.BirthdayDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Patronymic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_LastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddUpd_Worker";
            this.Text = "Добавить запись";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddUpd_Worker_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Patronymic;
        private System.Windows.Forms.DateTimePicker BirthdayDate;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TextBox_PassportNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_Money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}