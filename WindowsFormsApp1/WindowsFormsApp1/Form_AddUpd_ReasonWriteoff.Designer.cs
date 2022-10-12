
namespace WindowsFormsApp1
{
    partial class Form_AddUpd_ReasonWriteoff
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
            this.Button_Add_ReasonWriteOff = new System.Windows.Forms.Button();
            this.TextBox_Reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Причина списания";
            // 
            // Button_Add_ReasonWriteOff
            // 
            this.Button_Add_ReasonWriteOff.Location = new System.Drawing.Point(138, 301);
            this.Button_Add_ReasonWriteOff.Name = "Button_Add_ReasonWriteOff";
            this.Button_Add_ReasonWriteOff.Size = new System.Drawing.Size(75, 23);
            this.Button_Add_ReasonWriteOff.TabIndex = 4;
            this.Button_Add_ReasonWriteOff.Text = "Добавить";
            this.Button_Add_ReasonWriteOff.UseVisualStyleBackColor = true;
            this.Button_Add_ReasonWriteOff.Click += new System.EventHandler(this.Button_Add_ReasonWriteOff_Click);
            // 
            // TextBox_Reason
            // 
            this.TextBox_Reason.Location = new System.Drawing.Point(138, 139);
            this.TextBox_Reason.Multiline = true;
            this.TextBox_Reason.Name = "TextBox_Reason";
            this.TextBox_Reason.Size = new System.Drawing.Size(118, 48);
            this.TextBox_Reason.TabIndex = 3;
            // 
            // Form_AddUpd_ReasonWriteoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Add_ReasonWriteOff);
            this.Controls.Add(this.TextBox_Reason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddUpd_ReasonWriteoff";
            this.Text = "Добавить запись";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddUpd_ReasonWriteoff_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Add_ReasonWriteOff;
        private System.Windows.Forms.TextBox TextBox_Reason;
    }
}