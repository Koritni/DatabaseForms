
namespace WindowsFormsApp1
{
    partial class Form_Item_Supply
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
            this.Numeric_Amount = new System.Windows.Forms.NumericUpDown();
            this.ComboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Supply = new System.Windows.Forms.Button();
            this.TextBox_Item = new System.Windows.Forms.TextBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Numeric_Amount
            // 
            this.Numeric_Amount.Location = new System.Drawing.Point(155, 94);
            this.Numeric_Amount.Maximum = new decimal(new int[] {
            999999999,
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
            this.Numeric_Amount.TabIndex = 1;
            this.Numeric_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComboBox_Supplier
            // 
            this.ComboBox_Supplier.FormattingEnabled = true;
            this.ComboBox_Supplier.Location = new System.Drawing.Point(155, 153);
            this.ComboBox_Supplier.Name = "ComboBox_Supplier";
            this.ComboBox_Supplier.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Supplier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поставщик";
            // 
            // Button_Supply
            // 
            this.Button_Supply.Location = new System.Drawing.Point(201, 268);
            this.Button_Supply.Name = "Button_Supply";
            this.Button_Supply.Size = new System.Drawing.Size(75, 35);
            this.Button_Supply.TabIndex = 23;
            this.Button_Supply.Text = "Поставить товар";
            this.Button_Supply.UseVisualStyleBackColor = true;
            this.Button_Supply.Click += new System.EventHandler(this.Button_Supply_Click);
            // 
            // TextBox_Item
            // 
            this.TextBox_Item.Enabled = false;
            this.TextBox_Item.Location = new System.Drawing.Point(155, 27);
            this.TextBox_Item.Name = "TextBox_Item";
            this.TextBox_Item.ReadOnly = true;
            this.TextBox_Item.Size = new System.Drawing.Size(121, 20);
            this.TextBox_Item.TabIndex = 24;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(78, 268);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 35);
            this.Button_Cancel.TabIndex = 25;
            this.Button_Cancel.Text = "Отменить поставку";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_Item_Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.TextBox_Item);
            this.Controls.Add(this.Button_Supply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Supplier);
            this.Controls.Add(this.Numeric_Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Item_Supply";
            this.Text = "Form_Item_Supply";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Item_Supply_Closed);
            this.Shown += new System.EventHandler(this.Form_Item_Supply_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Numeric_Amount;
        private System.Windows.Forms.ComboBox ComboBox_Supplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Supply;
        private System.Windows.Forms.TextBox TextBox_Item;
        private System.Windows.Forms.Button Button_Cancel;
    }
}