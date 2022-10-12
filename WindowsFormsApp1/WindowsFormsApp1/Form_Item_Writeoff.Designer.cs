
namespace WindowsFormsApp1
{
    partial class Form_Item_Writeoff
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
            this.label1 = new System.Windows.Forms.Label();
            this.Numeric_Amount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Reason = new System.Windows.Forms.ComboBox();
            this.Button_Writeoff = new System.Windows.Forms.Button();
            this.TextBox_Item = new System.Windows.Forms.TextBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Товар";
            // 
            // Numeric_Amount
            // 
            this.Numeric_Amount.Location = new System.Drawing.Point(155, 90);
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
            this.Numeric_Amount.TabIndex = 15;
            this.Numeric_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Amount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Причина";
            // 
            // ComboBox_Reason
            // 
            this.ComboBox_Reason.FormattingEnabled = true;
            this.ComboBox_Reason.Location = new System.Drawing.Point(155, 146);
            this.ComboBox_Reason.Name = "ComboBox_Reason";
            this.ComboBox_Reason.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Reason.TabIndex = 19;
            // 
            // Button_Writeoff
            // 
            this.Button_Writeoff.Location = new System.Drawing.Point(201, 266);
            this.Button_Writeoff.Name = "Button_Writeoff";
            this.Button_Writeoff.Size = new System.Drawing.Size(75, 36);
            this.Button_Writeoff.TabIndex = 21;
            this.Button_Writeoff.Text = "Списать товар";
            this.Button_Writeoff.UseVisualStyleBackColor = true;
            this.Button_Writeoff.Click += new System.EventHandler(this.Button_Writeoff_Click);
            // 
            // TextBox_Item
            // 
            this.TextBox_Item.Enabled = false;
            this.TextBox_Item.Location = new System.Drawing.Point(155, 28);
            this.TextBox_Item.Name = "TextBox_Item";
            this.TextBox_Item.ReadOnly = true;
            this.TextBox_Item.Size = new System.Drawing.Size(121, 20);
            this.TextBox_Item.TabIndex = 22;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(77, 266);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 36);
            this.Button_Cancel.TabIndex = 23;
            this.Button_Cancel.Text = "Отменить списание";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_Item_Writeoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.TextBox_Item);
            this.Controls.Add(this.Button_Writeoff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBox_Reason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numeric_Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Item_Writeoff";
            this.Text = "Form_Item_Writeoff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Item_Writeoff_Close);
            this.Shown += new System.EventHandler(this.Form_Item_Writeoff_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Numeric_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Reason;
        private System.Windows.Forms.Button Button_Writeoff;
        private System.Windows.Forms.TextBox TextBox_Item;
        private System.Windows.Forms.Button Button_Cancel;
    }
}