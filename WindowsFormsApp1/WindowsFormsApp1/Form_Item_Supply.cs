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

namespace WindowsFormsApp1
{
    public partial class Form_Item_Supply : Form
    {
        private string id_Item, amountItem, id_Worker;

        public Form_Item_Supply(string id_Item, string item, string amountItem, string id_Worker)
        {
            InitializeComponent();
            FillComboBox();
            this.id_Item = id_Item;
            TextBox_Item.Text = item;
            this.amountItem = amountItem;
            this.id_Worker = id_Worker;
        }

        OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");

        private void FillComboBox()
        {
            //Заполнение выпадающего списка причин
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand SelectQuery_Supplier = new OleDbCommand("SELECT id, Название FROM Поставщик", connection);
            DataSet dataSet_Supplier = new DataSet();

            dataAdapter.SelectCommand = SelectQuery_Supplier;
            dataAdapter.Fill(dataSet_Supplier);

            ComboBox_Supplier.DataSource = dataSet_Supplier.Tables[0];
            ComboBox_Supplier.DisplayMember = "Название";
            ComboBox_Supplier.ValueMember = "id";
        }

        private void Button_Supply_Click(object sender, EventArgs e)
        {
            string id_Supplier = ComboBox_Supplier.SelectedValue.ToString();
            string dateSupply = DateTime.Now.ToString("MM-dd-yyyy");

            string amountItem = (int.Parse(this.amountItem) + (int)Numeric_Amount.Value).ToString(); //Подсчёт поставочных товаров с уже существующими 

            string amountLog = Numeric_Amount.Value.ToString();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_logWriteoff = new OleDbCommand("INSERT INTO Лог_ПоставкаТовара (Количество, ДатаПоставки, id_Товара, id_Поставщика, id_Сотрудника) VALUES (?,?,?,?,?)", connection);

            command_Insert_logWriteoff.Parameters.Add(amountLog, OleDbType.Integer).Value = amountLog;
            command_Insert_logWriteoff.Parameters.Add(dateSupply, OleDbType.Date).Value = dateSupply;
            command_Insert_logWriteoff.Parameters.Add(this.id_Item, OleDbType.Integer).Value = this.id_Item;
            command_Insert_logWriteoff.Parameters.Add(id_Supplier, OleDbType.Integer).Value = id_Supplier;
            command_Insert_logWriteoff.Parameters.Add(this.id_Worker, OleDbType.Integer).Value = this.id_Worker;

            dataAdapter.InsertCommand = command_Insert_logWriteoff;

            OleDbCommand command_Update_Item = new OleDbCommand("UPDATE Товар SET Количество = ? WHERE id = ?", connection);
            command_Update_Item.Parameters.Add(amountItem, OleDbType.Integer).Value = amountItem;
            command_Update_Item.Parameters.Add(this.id_Item, OleDbType.Integer).Value = this.id_Item;

            dataAdapter.UpdateCommand = command_Update_Item;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void Form_Item_Supply_Shown(object sender, EventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.Enabled = false;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Item_Supply_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.Enabled = true;
            parentForm.UpdateTable_Func();
        }
    }
}
