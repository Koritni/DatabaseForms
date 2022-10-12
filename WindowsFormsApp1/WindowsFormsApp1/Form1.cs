using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using iText;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string id_Worker;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            FillComboBox();
            
            try 
            { 
                ComboBox_Worker.SelectedIndex = 0;
                id_Worker = ComboBox_Worker.SelectedValue.ToString();
            }
            catch(ArgumentOutOfRangeException)
            {
                ComboBox_Worker.SelectedIndex = -1;
                id_Worker = "-1";
            }
        }

        private OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");
        public void FillComboBox()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            DataSet dataSet_Worker = new DataSet();
            OleDbCommand SelectQuery_Worker = new OleDbCommand("SELECT [Фамилия] & ' ' & [Имя] As FullName, id FROM Сотрудник", connection);

            dataAdapter.SelectCommand = SelectQuery_Worker;
            dataAdapter.Fill(dataSet_Worker);

            ComboBox_Worker.DataSource = dataSet_Worker.Tables[0];
            ComboBox_Worker.DisplayMember = "FullName";
            ComboBox_Worker.ValueMember = "id";
        }

        enum Table : ushort
        {
            //Основные таблицы
            Worker = 0,
            Item = 1,
            Supplier = 2,
            //Списки для таблиц выше
            List_CategoryItem = 3,
            List_ReasonWriteoff = 4,
            List_Trademark = 5,
            //Логи для чтения
            Log_ItemDelivery = 6, 
            Log_ItemSell = 7,
            Log_ItemWriteoff = 8
        }

        private Table table = new Table();

       

        public void UpdateTable_Func()
        {
            table = (Table)comboBox1.SelectedIndex;
            string Query = SelectQuery(table);
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(Query, connection);

            DataSet ds = new DataSet();

            //Обновляем DataSource
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dbDataAdapter.Fill(ds, SelectTable(table)); // String тут тип как таблица 
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        //Выход из приложения кнопкой которую мы создали
        private void ToolStripItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string SelectTable(Table table)
        {
            switch (table)
            {
                case Table.Worker: return "Сотрудник";
                case Table.Item: return "Товар";
                case Table.Supplier: return "Поставщик";
                case Table.List_CategoryItem: return "Список_КатегорияТовара";
                case Table.List_ReasonWriteoff: return "Список_ПричинаСписания";
                case Table.List_Trademark: return "Список_ТорговаяМарка";
                case Table.Log_ItemDelivery: return "Лог_ПоставкаТовара";
                case Table.Log_ItemSell: return "Лог_ПродажаТовара";
                case Table.Log_ItemWriteoff: return "Лог_СписаниеТовара";
                default: throw new Exception("Enum Table не имеет такого значения");
            }
        }

        //SQL команда для показа таблицы в DataGridView
        private string SelectQuery(Table table)
        {
            switch(table)
            {
                case Table.Worker: return "SELECT * FROM Сотрудник";
                case Table.Item: return "SELECT Товар.id, Товар.Название, Товар.Количество, Список_ТорговаяМарка.Название, Список_КатегорияТовара.Категория, " +
                       "Товар.id_ТорговаяМарка, Товар.id_Категория, Товар.Цена FROM (Товар " +
                       "INNER JOIN Список_ТорговаяМарка ON Товар.id_ТорговаяМарка = Список_ТорговаяМарка.id) " +
                       "INNER JOIN Список_КатегорияТовара ON Список_КатегорияТовара.id = Товар.id_Категория";

                case Table.Supplier: return "SELECT * FROM Поставщик";
                case Table.List_CategoryItem: return "SELECT * FROM Список_КатегорияТовара";
                case Table.List_ReasonWriteoff: return "SELECT * FROM Список_ПричинаСписания";
                case Table.List_Trademark: return "SELECT * FROM Список_ТорговаяМарка";

                case Table.Log_ItemDelivery: return "SELECT Лог_ПоставкаТовара.Количество, Лог_ПоставкаТовара.ДатаПоставки, Поставщик.Название, Товар.Название, " +
                        "Сотрудник.Фамилия, Сотрудник.Имя FROM ((Лог_ПоставкаТовара " +
                        "INNER JOIN Поставщик ON Лог_ПоставкаТовара.id_Поставщика = Поставщик.id) " +
                        "INNER JOIN Товар ON Лог_ПоставкаТовара.id_Товара = Товар.id) " +
                        "INNER JOIN Сотрудник ON Лог_ПоставкаТовара.id_Сотрудника = Сотрудник.id";

                case Table.Log_ItemSell: return "SELECT Лог_ПродажаТовара.Количество, Лог_ПродажаТовара.ДатаПродажи, Лог_ПродажаТовара.ИтоговаяЦена, Товар.Название, " +
                        "Сотрудник.Фамилия, Сотрудник.Имя FROM (Лог_ПродажаТовара " +
                        "INNER JOIN Товар ON Лог_ПродажаТовара.id_Товара = Товар.id) " +
                        "INNER JOIN Сотрудник ON Лог_ПродажаТовара.id_Сотрудника = Сотрудник.id";

                case Table.Log_ItemWriteoff: return "SELECT Лог_СписаниеТовара.Количество, Лог_СписаниеТовара.ДатаСписания, Товар.Название, " +
                        "Список_ПричинаСписания.Причина, Сотрудник.Фамилия, Сотрудник.Имя FROM ((Лог_СписаниеТовара " +
                        "INNER JOIN Товар ON Лог_СписаниеТовара.id_Товара = Товар.id) " +
                        "INNER JOIN Список_ПричинаСписания ON Лог_СписаниеТовара.id_Причины = Список_ПричинаСписания.id) " +
                        "INNER JOIN Сотрудник ON Лог_СписаниеТовара.id_Сотрудника = Сотрудник.id ";

                default: throw new Exception("Enum Table не имеет такого значения");
            }
        }

        private string DeleteQuery(Table table, string id)
        {
            switch (table)
            {
                case Table.Worker: return $"DELETE FROM Сотрудник WHERE id = {id}";
                case Table.Item: return $"DELETE FROM Товар WHERE id = {id}";
                case Table.Supplier: return $"DELETE FROM Поставщик WHERE id = {id}";
                case Table.List_CategoryItem: return $"DELETE FROM Список_КатегорияТовара WHERE id = {id}";
                case Table.List_ReasonWriteoff: return $"DELETE FROM Список_ПричинаСписания WHERE id = {id}";
                case Table.List_Trademark: return $"DELETE FROM Список_ТорговаяМарка WHERE id = {id}";
                default: throw new Exception("Enum Table не имеет такого значения, либо из этой таблицы удалить нельзя");
            }
        }

        private void ToolStripItem_Add_Click(object sender, EventArgs e)
        {
            table = (Table)comboBox1.SelectedIndex;
            switch (table)
            {
                case Table.Worker: 
                    Form_AddUpd_Worker form_Add_Worker = new Form_AddUpd_Worker();
                    form_Add_Worker.Owner = this;
                    form_Add_Worker.Show();
                    break;
                case Table.Item:
                    Form_AddUpd_Item form_Add_Item = new Form_AddUpd_Item();
                    form_Add_Item.Owner = this;
                    form_Add_Item.Show();
                    break;
                case Table.Supplier:
                    Form_AddUpd_Supplier form_Add_Supplier = new Form_AddUpd_Supplier();
                    form_Add_Supplier.Owner = this;
                    form_Add_Supplier.Show();
                    break;
                case Table.List_CategoryItem:
                    Form_AddUpd_CategoryItem form_Add_Category = new Form_AddUpd_CategoryItem();
                    form_Add_Category.Owner = this;
                    form_Add_Category.Show();
                    break;
                case Table.List_ReasonWriteoff:
                    Form_AddUpd_ReasonWriteoff form_Add_Reason = new Form_AddUpd_ReasonWriteoff();
                    form_Add_Reason.Owner = this;
                    form_Add_Reason.Show();
                    break;
                case Table.List_Trademark:
                    Form_AddUpd_TradeMark form_Add_TradeMark = new Form_AddUpd_TradeMark();
                    form_Add_TradeMark.Owner = this;
                    form_Add_TradeMark.Show();
                    break;
                default: MessageBox.Show("Enum Table не имеет такого значения"); break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable_Func();

            //Если выбрана таблица Товар, то кнопки: Поставить товар, Продать Товар, Списать товар включены
            if(comboBox1.SelectedIndex == 1 && id_Worker != null)
            {
                Button_SupplyItem.Enabled = true;
                Button_SoldItem.Enabled = true;
                Button_WriteOffItem.Enabled = true;
            }
            else
            {
                Button_SupplyItem.Enabled = false;
                Button_SoldItem.Enabled = false;
                Button_WriteOffItem.Enabled = false;
            }

            //
            if (comboBox1.SelectedIndex >= 5 || (comboBox1.SelectedIndex <= 3 && comboBox1.SelectedIndex >= 1))
            {
                Button_createPDF.Enabled = true;
            }
            else
            {
                Button_createPDF.Enabled = false;
            }

            //Если выбрана таблица "Лог", тогда кнопки: Добавить, обновить, удалить выключены
            if (comboBox1.SelectedIndex >= 6)
            {
                ToolStripItem_Add.Enabled = false;
                ToolStripItem_Update.Enabled = false;
                ToolStripItem_Delete.Enabled = false;
                
            }
            else
            {
                ToolStripItem_Add.Enabled = true;
                ToolStripItem_Update.Enabled = true;
                ToolStripItem_Delete.Enabled = true;
            }
        }

        private void ToolStripItem_Update_Click(object sender, EventArgs e)
        {
            //Получение данных с выделенной строки
            int index = dataGridView1.CurrentCell.RowIndex;
            string id = checkIdTable(index);

            if (id == null)
            {
                return;
            }

            if (id_Worker == null || (Table.Worker == table && id == id_Worker))
            {
                MessageBox.Show("Работник не может обновить себя либо работник не выбран");
                return;
            }

            switch (table)
            {
                case Table.Worker:
                    Form_AddUpd_Worker form_Upd_Worker = new Form_AddUpd_Worker(id,
                        dataGridView1.Rows[index].Cells[1].Value.ToString(), //Фамилия
                        dataGridView1.Rows[index].Cells[2].Value.ToString(), //Имя
                        dataGridView1.Rows[index].Cells[3].Value.ToString(), //Отчество
                        dataGridView1.Rows[index].Cells[4].Value.ToString(), // Дата Рождения
                        dataGridView1.Rows[index].Cells[5].Value.ToString(), // Номер Паспорта
                        dataGridView1.Rows[index].Cells[6].Value.ToString()  // Зарплата
                        );
                    form_Upd_Worker.Owner = this;
                    form_Upd_Worker.Show();
                    break;
                case Table.Item:
                    Form_AddUpd_Item form_Upd_Item = new Form_AddUpd_Item(id,
                        dataGridView1.Rows[index].Cells[1].Value.ToString(), //Название
                        dataGridView1.Rows[index].Cells[2].Value.ToString(), //Количество
                        dataGridView1.Rows[index].Cells[5].Value.ToString(), //id товарной марки
                        dataGridView1.Rows[index].Cells[6].Value.ToString(), //id категории
                        dataGridView1.Rows[index].Cells[7].Value.ToString()  //Цена
                        );
                    form_Upd_Item.Owner = this;
                    form_Upd_Item.Show();
                    break;
                case Table.Supplier:
                    Form_AddUpd_Supplier form_Upd_Supplier = new Form_AddUpd_Supplier(id,
                        dataGridView1.Rows[index].Cells[1].Value.ToString(),  //Название
                        dataGridView1.Rows[index].Cells[2].Value.ToString(),  //Дата контракта
                        dataGridView1.Rows[index].Cells[3].Value.ToString()); //Адрес
                    form_Upd_Supplier.Owner = this;
                    form_Upd_Supplier.Show();
                    break;
                case Table.List_CategoryItem:
                    Form_AddUpd_CategoryItem form_Upd_Category = new Form_AddUpd_CategoryItem(id, dataGridView1.Rows[index].Cells[1].Value.ToString()); //Категория
                    form_Upd_Category.Owner = this;
                    form_Upd_Category.Show();
                    break;
                case Table.List_ReasonWriteoff:
                    Form_AddUpd_ReasonWriteoff form_Upd_Reason = new Form_AddUpd_ReasonWriteoff(id, dataGridView1.Rows[index].Cells[1].Value.ToString()); //Причина
                    form_Upd_Reason.Owner = this;
                    form_Upd_Reason.Show();
                    break;
                case Table.List_Trademark:
                     Form_AddUpd_TradeMark form_Upd_TradeMark = new Form_AddUpd_TradeMark(id,
                        dataGridView1.Rows[index].Cells[1].Value.ToString(),  //Название
                        dataGridView1.Rows[index].Cells[2].Value.ToString(),  //Описание
                        dataGridView1.Rows[index].Cells[3].Value.ToString()); //Телефон
                     form_Upd_TradeMark.Owner = this;
                     form_Upd_TradeMark.Show();
                     break;
                default: MessageBox.Show("something"); break;
            }
        }

        private void ToolStripItem_Delete_Click(object sender, EventArgs e)
        {
            //Получение данных с выделенной строки
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index < 0)
            {
                MessageBox.Show("Выберите ячейку в таблице, чтобы удалить данные");
                return;
            }
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            if (id_Worker == null || (Table.Worker == table && id == id_Worker))
            {
                MessageBox.Show("Работник не может удалить себя либо работник не выбран");
                return;
            }

            if (id == null || id == "")
            {
                MessageBox.Show("Выберите ячейку в таблице в которой есть данные чтобы её удалить");
                return;
            }

            DialogResult result = MessageBox.Show("Вы точно хотите удалить запись в данной таблице?","Удаление записи", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                return;
            }

            table = (Table)comboBox1.SelectedIndex;
            OleDbCommand DeleteCommand = new OleDbCommand(DeleteQuery(table, id), connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();


            dataAdapter.DeleteCommand = DeleteCommand;

            connection.Open();
            try
            { dataAdapter.DeleteCommand.ExecuteNonQuery(); }
            catch (OleDbException)
            {
                connection.Close();
                MessageBox.Show("Эта строка связана с другой записью в базе данных");
                return;
            }
            
            connection.Close();
            UpdateTable_Func();
            if(table == Table.Worker)
            {
                FillComboBox();
            }
        }

        private void Button_SupplyItem_Click(object sender, EventArgs e) //Поставка товара - добавление уже существующего товара
        {
            if (!checkWorker()) { return; } // проверка на работника

            int index = dataGridView1.CurrentCell.RowIndex;
            string id = checkIdTable(index);

            if (id == null)
            {
                return;
            }

            Form_Item_Supply form_Item_Supply = new Form_Item_Supply(id,
                    dataGridView1.Rows[index].Cells[1].Value.ToString(), //Название товара
                    dataGridView1.Rows[index].Cells[2].Value.ToString(), //Кол-во товара
                    this.id_Worker
                );

            form_Item_Supply.Owner = this;
            form_Item_Supply.Show();
        }

        private void Button_SoldItem_Click(object sender, EventArgs e) //Продажа Товара - удаление товара с счётом чека
        {
            if (!checkWorker()) { return; } // проверка на работника

            int index = dataGridView1.CurrentCell.RowIndex;
            string id = checkIdTable(index);

            if (id == null)
            {
                return;
            }

            int amount = (int)dataGridView1.Rows[index].Cells[2].Value;
            if (amount == 0)
            {
                MessageBox.Show("Выберите товар который есть на складе");
                return;
            }

            Form_Item_Sold form_Item_Sold = new Form_Item_Sold(id,
               dataGridView1.Rows[index].Cells[1].Value.ToString(), //Название товара
               dataGridView1.Rows[index].Cells[2].Value.ToString(), //Кол-во товара
               dataGridView1.Rows[index].Cells[7].Value.ToString(), //Цена товара
               this.id_Worker
               );
            form_Item_Sold.Owner = this;
            form_Item_Sold.Show();
        }

        private void Button_WriteOffItem_Click(object sender, EventArgs e) // Списание товара - удаление товара без счёта чека
        {
            if (!checkWorker()) {return;} // проверка на работника

            int index = dataGridView1.CurrentCell.RowIndex;
            string id = checkIdTable(index);

            if (id == null)
            {
                return;
            }

            int amount = (int)dataGridView1.Rows[index].Cells[2].Value;
            if (amount == 0)
            {
                MessageBox.Show("Выберите товар который есть на складе");
                return;
            }

            Form_Item_Writeoff form_Item_Writeoff = new Form_Item_Writeoff(id,
              dataGridView1.Rows[index].Cells[1].Value.ToString(), //Название товара
              dataGridView1.Rows[index].Cells[2].Value.ToString(), //Кол-во товара
              this.id_Worker
              );
            form_Item_Writeoff.Owner = this;
            form_Item_Writeoff.Show();
        }

        private string checkIdTable(int index)
        {
            if (index < 0)
            {
                MessageBox.Show("Выберите ячейку в таблице, чтобы обновить данные");
                return null;
            }
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            if (id == null || id == "")

            {
                MessageBox.Show("Выберите ячейку в таблице в которой есть данные чтобы её обновить");
                return null;
            }
            else
            {
                return id;
            }
        }

        private bool checkWorker()
        {
            if(ComboBox_Worker.SelectedIndex == -1)
            {
                MessageBox.Show("Добавьте и выберите работника, чтобы работать с товаром");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ComboBox_Worker_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Worker = ComboBox_Worker.SelectedValue.ToString();
        }

        private void Button_createPDF_Click(object sender, EventArgs e)
        {

            //pdfDoc.GetCatalog().SetLang(new iText.Kernel.Pdf.PdfString("ru-RU"));
            iText.Kernel.Font.PdfFont font = iText.Kernel.Font.PdfFontFactory.CreateFont("Fonts/arialmt.ttf", "Cp1251"); //iText.Kernel.Font.PdfFontFactory.CreateFont(SystemFonts.DefaultFont); //загрузить шрифт в проект
            int rows = dataGridView1.Rows.Count;
            int columns = dataGridView1.Columns.Count;
            iText.Layout.Element.Table tablePdf = new iText.Layout.Element.Table(columns);
            iText.Kernel.Pdf.PdfDocument pdfDoc;
            FileInfo file;
            tablePdf.SetFont(font);

            switch (table)
            {
                case Table.Item:
                    file = new FileInfo("Result/ReportItem.pdf");

                    if (!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportItem.pdf"));

                    tablePdf.AddHeaderCell("id");
                    tablePdf.AddHeaderCell("Товар");
                    tablePdf.AddHeaderCell("Количество");
                    tablePdf.AddHeaderCell("Торговая марка");
                    tablePdf.AddHeaderCell("Категория");
                    tablePdf.AddHeaderCell("id Торговая марка");
                    tablePdf.AddHeaderCell("id Категория");
                    tablePdf.AddHeaderCell("Цена");
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    break;

                case Table.Supplier:
                    file = new FileInfo("Result/ReportSupplier.pdf");

                    if (!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportSupplier.pdf"));

                    tablePdf.AddHeaderCell("id");
                    tablePdf.AddHeaderCell("Поставщик");
                    tablePdf.AddHeaderCell("Дата подписания контракта");
                    tablePdf.AddHeaderCell("Адрес");
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    break;

                case Table.List_CategoryItem:
                    file = new FileInfo("Result/ReportCategory.pdf");

                    if (!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportCategory.pdf"));

                    tablePdf.AddHeaderCell("id");
                    tablePdf.AddHeaderCell("Категория");
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    break;

                case Table.Log_ItemDelivery:
                    file = new FileInfo("Result/ReportSupply.pdf");

                    if(!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportSupply.pdf"));

                    tablePdf.AddHeaderCell("Количество");
                    tablePdf.AddHeaderCell("Дата поставки");
                    tablePdf.AddHeaderCell("Поставщик");
                    tablePdf.AddHeaderCell("Товар");
                    tablePdf.AddHeaderCell("Фамилия сотрудника");
                    tablePdf.AddHeaderCell("Имя сотрудника");
                    for(int i = 0; i < rows - 1; i++)
                    {
                        for(int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        
                    }
                    break;

                case Table.List_Trademark:
                    file = new FileInfo("Result/ReportTrademark.pdf");

                    if (!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportTrademark.pdf"));

                    tablePdf.AddHeaderCell("id");
                    tablePdf.AddHeaderCell("Название");
                    tablePdf.AddHeaderCell("Описание");
                    tablePdf.AddHeaderCell("Телефон");
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }

                    }
                    break;

                case Table.Log_ItemSell:

                    file = new FileInfo("Result/ReportSold.pdf");
                    if (!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportSold.pdf"));

                    tablePdf.AddHeaderCell("Количество");
                    tablePdf.AddHeaderCell("Дата продажи");
                    tablePdf.AddHeaderCell("Итоговая цена");
                    tablePdf.AddHeaderCell("Товар");
                    tablePdf.AddHeaderCell("Фамилия сотрудника");
                    tablePdf.AddHeaderCell("Имя сотрудника");
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    
                    break;

                case Table.Log_ItemWriteoff:
                    file = new FileInfo("Result/ReportWriteOff.pdf");
                    if (!fileCreate(file))
                    {
                        return;
                    }
                    pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter("Result/ReportWriteOff.pdf"));

                    tablePdf.AddHeaderCell("Количество");
                    tablePdf.AddHeaderCell("Дата списания");
                    tablePdf.AddHeaderCell("Товар");
                    tablePdf.AddHeaderCell("Причина списания");
                    tablePdf.AddHeaderCell("Фамилия сотрудника");
                    tablePdf.AddHeaderCell("Имя сотрудника");
                    for (int i = 0; i < rows - 1; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            tablePdf.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }

                    }
                    break;

                default: MessageBox.Show("Enum Table не имеет такого значения"); return;
            }
            iText.Layout.Document doc = new iText.Layout.Document(pdfDoc);
            doc.Add(tablePdf);
            doc.Close();
            pdfDoc.Close();
            MessageBox.Show("Файл создан в файле Result");
        }

        private bool fileCreate(FileInfo file)
        {
            Stream createStream;

            try
            {
                using (createStream = file.Create())
                {
                    if (!file.Exists)
                    {
                        MessageBox.Show("Файл не создался"); return false;
                    }
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Файл используется приложением или пользователем"); return false;
            }
            return true;
        }
    }
}
