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
    public partial class Form_Item_Writeoff : Form
    {
        private string id_Item, amountItem, id_Worker;
        public Form_Item_Writeoff(string id_Item, string item, string amountItem, string id_Worker)
        {
            InitializeComponent();
            FillCombobox();
            ComboBox_Reason.SelectedIndex = 0;
            this.id_Item = id_Item;
            this.amountItem = amountItem;
            this.id_Worker = id_Worker;
            TextBox_Item.Text = item;
            Numeric_Amount.Maximum = int.Parse(amountItem);
        }

        OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");


        private void FillCombobox()
        {
            //Заполнение выпадающего списка причин
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand SelectQuery_Reason = new OleDbCommand("SELECT id, Причина FROM Список_ПричинаСписания", connection);
            DataSet dataSet_Reason = new DataSet();

            dataAdapter.SelectCommand = SelectQuery_Reason;
            dataAdapter.Fill(dataSet_Reason);

            ComboBox_Reason.DataSource = dataSet_Reason.Tables[0];
            ComboBox_Reason.DisplayMember = "Причина";
            ComboBox_Reason.ValueMember = "id";
        }

        private void Button_Writeoff_Click(object sender, EventArgs e)
        {
            string id_Reason = ComboBox_Reason.SelectedValue.ToString();
            string dateWriteoff = DateTime.Now.ToString("MM-dd-yyyy");

            string amountItem = (int.Parse(this.amountItem) - (int)Numeric_Amount.Value).ToString(); //Подсчёт остатков товара

            string amountLog = Numeric_Amount.Value.ToString();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_logWriteoff = new OleDbCommand("INSERT INTO Лог_СписаниеТовара (Количество, ДатаСписания, id_Товара, id_Причины, id_Сотрудника) VALUES (?,?,?,?,?)", connection);

            command_Insert_logWriteoff.Parameters.Add(amountLog, OleDbType.Integer).Value = amountLog;
            command_Insert_logWriteoff.Parameters.Add(dateWriteoff, OleDbType.Date).Value = dateWriteoff;
            command_Insert_logWriteoff.Parameters.Add(this.id_Item, OleDbType.Integer).Value = this.id_Item;
            command_Insert_logWriteoff.Parameters.Add(id_Reason, OleDbType.Integer).Value = id_Reason;
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

        private void Form_Item_Writeoff_Close(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.Enabled = true;
            parentForm.UpdateTable_Func();
        }

        private void Form_Item_Writeoff_Shown(object sender, EventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.Enabled = false;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) //8 - Backspace
            {
                e.Handled = true;
            }
        }
    }
}
