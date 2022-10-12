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
    public partial class Form_AddUpd_TradeMark : Form
    {
        public Form_AddUpd_TradeMark()
        {
            InitializeComponent();
        }

        private string id_Update = null;

        public Form_AddUpd_TradeMark(string id, string name, string description, string telephone)
        {
            InitializeComponent();
            id_Update = id;
            TextBox_Name.Text = name;
            TextBox_Description.Text = description;
            TextBox_Telephone.Text = telephone; 
        }

        private void TextBox_Telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char telephone = e.KeyChar;
            if(!Char.IsDigit(telephone) && telephone != 8 && telephone != 32 && telephone != 43 && telephone != 45) // 8 - BackSpace, 32 - пробел, 43 - знак "+", 45 - знак "-"
            {
                e.Handled = true;
            }
        }

        private void Button_Add_Trademark_Click(object sender, EventArgs e)
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
        OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");

        private void InsertFunc()
        {
            string name = TextBox_Name.Text;
            string description = TextBox_Description.Text;
            string telephone = TextBox_Telephone.Text;

            if(name.Length == 0)
            {
                MessageBox.Show("Поле 'Название' пустое");
                return;
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_Trademark = new OleDbCommand("INSERT INTO Список_ТорговаяМарка (Название, Описание, Телефон) VALUES (?,?,?)", connection);

            command_Insert_Trademark.Parameters.Add(@name, OleDbType.VarChar).Value = name;
            command_Insert_Trademark.Parameters.Add(@description, OleDbType.VarChar).Value = description;
            command_Insert_Trademark.Parameters.Add(@telephone, OleDbType.VarChar).Value = telephone;

            dataAdapter.InsertCommand = command_Insert_Trademark;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
        
        private void UpdateFunc()
        {
            string name = TextBox_Name.Text;
            string description = TextBox_Description.Text;
            string telephone = TextBox_Telephone.Text;
            string id = id_Update;


            if (name.Length == 0)
            {
                MessageBox.Show("Поле 'Название' пустое");
                return;
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Update_Trademark = new OleDbCommand("UPDATE Список_ТорговаяМарка SET Название = ?, Описание = ?, Телефон = ? WHERE id = ?", connection);

            command_Update_Trademark.Parameters.Add(name, OleDbType.VarChar).Value = name;
            command_Update_Trademark.Parameters.Add(description, OleDbType.VarChar).Value = description;
            command_Update_Trademark.Parameters.Add(telephone, OleDbType.VarChar).Value = telephone;
            command_Update_Trademark.Parameters.Add(id, OleDbType.Integer).Value = id;

            dataAdapter.UpdateCommand = command_Update_Trademark;

            connection.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void Form_AddUpd_TradeMark_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.UpdateTable_Func();
        }
    }
}
