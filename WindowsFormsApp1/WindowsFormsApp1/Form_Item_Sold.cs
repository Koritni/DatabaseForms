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
    public partial class Form_Item_Sold : Form
    {


        private string id_Item, id_Worker;
        private int amountItem;
        private double money;
        public Form_Item_Sold(string id_Item, string item, string amountItem, string money, string id_Worker)
        {
            InitializeComponent();
            this.id_Item = id_Item;
            TextBox_Item.Text = item;
            this.amountItem = int.Parse(amountItem);
            this.money = double.Parse(money);
            this.id_Worker = id_Worker;
            Numeric_Amount.Maximum = int.Parse(amountItem);
        }

       

        private void Numeric_Amount_ValueChanged(object sender, EventArgs e)
        {
            int amount = (int) Numeric_Amount.Value;
            double moneyResult = this.money * amount;

            TextBox_Money.Text = moneyResult.ToString();
        }

        private void Button_Sold_Click(object sender, EventArgs e)
        {
            string amountLog = Numeric_Amount.Value.ToString();
            string dateSold = DateTime.Now.ToString("MM-dd-yyyy");
            string moneyResult = TextBox_Money.Text;

            string amountItem = (this.amountItem - (int)Numeric_Amount.Value).ToString();


            OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_LogSold = new OleDbCommand("INSERT INTO Лог_ПродажаТовара (Количество, ДатаПродажи, id_Товара, id_Сотрудника, ИтоговаяЦена) VALUES (?,?,?,?,?)", connection);
            command_Insert_LogSold.Parameters.Add(amountLog, OleDbType.Integer).Value = amountLog;
            command_Insert_LogSold.Parameters.Add(dateSold, OleDbType.Date).Value = dateSold;
            command_Insert_LogSold.Parameters.Add(this.id_Item, OleDbType.Integer).Value = this.id_Item;
            command_Insert_LogSold.Parameters.Add(this.id_Worker, OleDbType.Integer).Value = this.id_Worker;
            command_Insert_LogSold.Parameters.Add(moneyResult, OleDbType.Double).Value = moneyResult;
            dataAdapter.InsertCommand = command_Insert_LogSold;

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

        private void Form_Item_Sold_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.Enabled = true;
            parentForm.UpdateTable_Func();
        }

        private void Form_Item_Sold_Shown(object sender, EventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.Enabled = false;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
