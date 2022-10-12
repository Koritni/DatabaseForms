
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_SupplyItem = new System.Windows.Forms.Button();
            this.Button_SoldItem = new System.Windows.Forms.Button();
            this.Button_WriteOffItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Worker = new System.Windows.Forms.ComboBox();
            this.Button_createPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(575, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.ToolStripItem_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItem_Add,
            this.ToolStripItem_Update,
            this.ToolStripItem_Delete});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // ToolStripItem_Add
            // 
            this.ToolStripItem_Add.Name = "ToolStripItem_Add";
            this.ToolStripItem_Add.Size = new System.Drawing.Size(172, 22);
            this.ToolStripItem_Add.Text = "Добавить данные";
            this.ToolStripItem_Add.Click += new System.EventHandler(this.ToolStripItem_Add_Click);
            // 
            // ToolStripItem_Update
            // 
            this.ToolStripItem_Update.Name = "ToolStripItem_Update";
            this.ToolStripItem_Update.Size = new System.Drawing.Size(172, 22);
            this.ToolStripItem_Update.Text = "Обновить данные";
            this.ToolStripItem_Update.Click += new System.EventHandler(this.ToolStripItem_Update_Click);
            // 
            // ToolStripItem_Delete
            // 
            this.ToolStripItem_Delete.Name = "ToolStripItem_Delete";
            this.ToolStripItem_Delete.Size = new System.Drawing.Size(172, 22);
            this.ToolStripItem_Delete.Text = "Удалить данные";
            this.ToolStripItem_Delete.Click += new System.EventHandler(this.ToolStripItem_Delete_Click);
            // 
            // ToolStripItem_Exit
            // 
            this.ToolStripItem_Exit.Name = "ToolStripItem_Exit";
            this.ToolStripItem_Exit.Size = new System.Drawing.Size(54, 20);
            this.ToolStripItem_Exit.Text = "Выход";
            this.ToolStripItem_Exit.Click += new System.EventHandler(this.ToolStripItem_Exit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сотрудник",
            "Товар",
            "Поставщик",
            "Список_КатегорияТовара",
            "Список_ПричинаСписания",
            "Список_ТорговаяМарка",
            "Лог_ПоставкаТовара",
            "Лог_ПродажаТовара",
            "Лог_СписаниеТовара"});
            this.comboBox1.Location = new System.Drawing.Point(596, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор Таблицы:";
            // 
            // Button_SupplyItem
            // 
            this.Button_SupplyItem.Location = new System.Drawing.Point(624, 102);
            this.Button_SupplyItem.Name = "Button_SupplyItem";
            this.Button_SupplyItem.Size = new System.Drawing.Size(115, 23);
            this.Button_SupplyItem.TabIndex = 4;
            this.Button_SupplyItem.Text = "Поставка Товара";
            this.Button_SupplyItem.UseVisualStyleBackColor = true;
            this.Button_SupplyItem.Click += new System.EventHandler(this.Button_SupplyItem_Click);
            // 
            // Button_SoldItem
            // 
            this.Button_SoldItem.Location = new System.Drawing.Point(624, 141);
            this.Button_SoldItem.Name = "Button_SoldItem";
            this.Button_SoldItem.Size = new System.Drawing.Size(115, 23);
            this.Button_SoldItem.TabIndex = 5;
            this.Button_SoldItem.Text = "Продажа Товара";
            this.Button_SoldItem.UseVisualStyleBackColor = true;
            this.Button_SoldItem.Click += new System.EventHandler(this.Button_SoldItem_Click);
            // 
            // Button_WriteOffItem
            // 
            this.Button_WriteOffItem.Location = new System.Drawing.Point(624, 185);
            this.Button_WriteOffItem.Name = "Button_WriteOffItem";
            this.Button_WriteOffItem.Size = new System.Drawing.Size(115, 23);
            this.Button_WriteOffItem.TabIndex = 6;
            this.Button_WriteOffItem.Text = "Списание Товара";
            this.Button_WriteOffItem.UseVisualStyleBackColor = true;
            this.Button_WriteOffItem.Click += new System.EventHandler(this.Button_WriteOffItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сотрудник";
            // 
            // ComboBox_Worker
            // 
            this.ComboBox_Worker.FormattingEnabled = true;
            this.ComboBox_Worker.Location = new System.Drawing.Point(596, 329);
            this.ComboBox_Worker.Name = "ComboBox_Worker";
            this.ComboBox_Worker.Size = new System.Drawing.Size(156, 21);
            this.ComboBox_Worker.TabIndex = 7;
            this.ComboBox_Worker.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Worker_SelectedIndexChanged);
            // 
            // Button_createPDF
            // 
            this.Button_createPDF.Location = new System.Drawing.Point(624, 229);
            this.Button_createPDF.Name = "Button_createPDF";
            this.Button_createPDF.Size = new System.Drawing.Size(115, 23);
            this.Button_createPDF.TabIndex = 9;
            this.Button_createPDF.Text = "Генерация отчёта";
            this.Button_createPDF.UseVisualStyleBackColor = true;
            this.Button_createPDF.Click += new System.EventHandler(this.Button_createPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 371);
            this.Controls.Add(this.Button_createPDF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Worker);
            this.Controls.Add(this.Button_WriteOffItem);
            this.Controls.Add(this.Button_SoldItem);
            this.Controls.Add(this.Button_SupplyItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Delete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Exit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_SupplyItem;
        private System.Windows.Forms.Button Button_SoldItem;
        private System.Windows.Forms.Button Button_WriteOffItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Worker;
        private System.Windows.Forms.Button Button_createPDF;
    }
}

