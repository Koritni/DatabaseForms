
namespace WindowsFormsApp1
{
    partial class Form_AddUpd_Item
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
            this.Button_Add = new System.Windows.Forms.Button();
            this.Numeric_Amount = new System.Windows.Forms.NumericUpDown();
            this.ComboBox_Category = new System.Windows.Forms.ComboBox();
            this.ComboBox_Trademark = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Money = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(98, 34);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(122, 20);
            this.TextBox_Name.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(122, 301);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Numeric_Amount
            // 
            this.Numeric_Amount.Location = new System.Drawing.Point(98, 88);
            this.Numeric_Amount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Numeric_Amount.Name = "Numeric_Amount";
            this.Numeric_Amount.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Amount.TabIndex = 2;
            this.Numeric_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_Amount_KeyPress);
            // 
            // ComboBox_Category
            // 
            this.ComboBox_Category.FormattingEnabled = true;
            this.ComboBox_Category.Location = new System.Drawing.Point(98, 191);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Category.TabIndex = 3;
            // 
            // ComboBox_Trademark
            // 
            this.ComboBox_Trademark.FormattingEnabled = true;
            this.ComboBox_Trademark.Location = new System.Drawing.Point(99, 139);
            this.ComboBox_Trademark.Name = "ComboBox_Trademark";
            this.ComboBox_Trademark.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Trademark.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Торговая марка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Категория товара";
            // 
            // TextBox_Money
            // 
            this.TextBox_Money.Location = new System.Drawing.Point(98, 242);
            this.TextBox_Money.Name = "TextBox_Money";
            this.TextBox_Money.Size = new System.Drawing.Size(121, 20);
            this.TextBox_Money.TabIndex = 9;
            this.TextBox_Money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Money_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цена";
            // 
            // Form_AddUpd_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_Money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Trademark);
            this.Controls.Add(this.ComboBox_Category);
            this.Controls.Add(this.Numeric_Amount);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.TextBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddUpd_Item";
            this.Text = "Добавить запись";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AppUpd_Item_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.NumericUpDown Numeric_Amount;
        private System.Windows.Forms.ComboBox ComboBox_Category;
        private System.Windows.Forms.ComboBox ComboBox_Trademark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Money;
        private System.Windows.Forms.Label label5;
    }
}