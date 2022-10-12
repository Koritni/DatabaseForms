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
    public partial class Form_AddUpd_Supplier : Form
    {
        public Form_AddUpd_Supplier()
        {
            InitializeComponent();
            Date_Contract.MaxDate = DateTime.Now;
        }

        private string id_Update = null;
        public Form_AddUpd_Supplier(string id_Update, string name, string contractDate, string adress)
        {
            InitializeComponent();
            Button_Add.Text = "Обновить";
            Date_Contract.MaxDate = DateTime.Now;
            this.id_Update = id_Update;
            TextBox_Name.Text = name;
            Date_Contract.Value = DateTime.Parse(contractDate);
            TextBox_Adress.Text = adress;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if(id_Update == null)
            {
                InsertFunc();
            }
            else
            {
                UpdateFunc();
            }
        }

        private void InsertFunc()
        {
            string name = TextBox_Name.Text;
            string contractDate = Date_Contract.Value.ToString("MM-dd-yyyy");
            string adress = TextBox_Adress.Text;

            if (Name.Length == 0)
            {
                MessageBox.Show("Поле 'Название' должно содержать в себе символы");
                return;
            }

            OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_Supplier = new OleDbCommand("INSERT INTO Поставщик (Название, Дата_Контракта, Адрес) VALUES (?,?,?)", connection);


            command_Insert_Supplier.Parameters.Add(name, OleDbType.VarChar).Value = name;
            command_Insert_Supplier.Parameters.Add(contractDate, OleDbType.Date).Value = contractDate;
            command_Insert_Supplier.Parameters.Add(adress, OleDbType.VarChar).Value = adress;

            dataAdapter.InsertCommand = command_Insert_Supplier;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void UpdateFunc()
        {
            string name = TextBox_Name.Text;
            string contractDate = Date_Contract.Value.ToString("MM-dd-yyyy");
            string adress = TextBox_Adress.Text;
            string id = id_Update;

            if (Name.Length == 0)
            {
                MessageBox.Show("Поле 'Название' должно содержать в себе символы");
                return;
            }

            OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Update_Supplier = new OleDbCommand("UPDATE Поставщик SET Название = ?, Дата_Контракта = ?, Адрес = ? WHERE id = ?", connection);


            command_Update_Supplier.Parameters.Add(name, OleDbType.VarChar).Value = name;
            command_Update_Supplier.Parameters.Add(contractDate, OleDbType.Date).Value = contractDate;
            command_Update_Supplier.Parameters.Add(adress, OleDbType.VarChar).Value = adress;
            command_Update_Supplier.Parameters.Add(id, OleDbType.Integer).Value = id;

            dataAdapter.UpdateCommand = command_Update_Supplier;

            connection.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void Form_AddUpd_Supplier_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.UpdateTable_Func();
        }
    }
}
