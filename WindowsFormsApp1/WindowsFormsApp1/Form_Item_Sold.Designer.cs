
namespace WindowsFormsApp1
{
    partial class Form_Item_Sold
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
            this.label2 = new System.Windows.Forms.Label();
            this.Numeric_Amount = new System.Windows.Forms.NumericUpDown();
            this.TextBox_Money = new System.Windows.Forms.TextBox();
            this.Button_Sold = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество";
            // 
            // Numeric_Amount
            // 
            this.Numeric_Amount.Location = new System.Drawing.Point(158, 67);
            this.Numeric_Amount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Numeric_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Amount.Name = "Numeric_Amount";
            this.Numeric_Amount.Size = new System.Drawing.Size(121, 20);
            this.Numeric_Amount.TabIndex = 8;
            this.Numeric_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Amount.ValueChanged += new System.EventHandler(this.Numeric_Amount_ValueChanged);
            // 
            // TextBox_Money
            // 
            this.TextBox_Money.Enabled = false;
            this.TextBox_Money.Location = new System.Drawing.Point(158, 103);
            this.TextBox_Money.Name = "TextBox_Money";
            this.TextBox_Money.ReadOnly = true;
            this.TextBox_Money.Size = new System.Drawing.Size(41, 20);
            this.TextBox_Money.TabIndex = 13;
            this.TextBox_Money.Text = "0";
            // 
            // Button_Sold
            // 
            this.Button_Sold.Location = new System.Drawing.Point(204, 265);
            this.Button_Sold.Name = "Button_Sold";
            this.Button_Sold.Size = new System.Drawing.Size(75, 36);
            this.Button_Sold.TabIndex = 22;
            this.Button_Sold.Text = "Продать товар";
            this.Button_Sold.UseVisualStyleBackColor = true;
            this.Button_Sold.Click += new System.EventHandler(this.Button_Sold_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Цена";
            // 
            // TextBox_Item
            // 
            this.TextBox_Item.Enabled = false;
            this.TextBox_Item.Location = new System.Drawing.Point(158, 27);
            this.TextBox_Item.Name = "TextBox_Item";
            this.TextBox_Item.ReadOnly = true;
            this.TextBox_Item.Size = new System.Drawing.Size(121, 20);
            this.TextBox_Item.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Товар";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(71, 265);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 36);
            this.Button_Cancel.TabIndex = 27;
            this.Button_Cancel.Text = "Отменить продажу";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_Item_Sold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.TextBox_Item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Sold);
            this.Controls.Add(this.TextBox_Money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numeric_Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Item_Sold";
            this.Text = "Form_Item_Sold";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Item_Sold_Closed);
            this.Shown += new System.EventHandler(this.Form_Item_Sold_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Numeric_Amount;
        private System.Windows.Forms.TextBox TextBox_Money;
        private System.Windows.Forms.Button Button_Sold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Cancel;
    }
}