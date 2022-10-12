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
    public partial class Form_AddUpd_CategoryItem : Form
    {
        private string id_Update = null;
        public Form_AddUpd_CategoryItem()
        {
            InitializeComponent();
        }
        public Form_AddUpd_CategoryItem(string id, string category)
        {
            InitializeComponent();
            Button_Add_CategoryItem.Text = "Обновить";
            id_Update = id;
            TextBox_Category.Text = category;
        }

        private void Button_Add_CategoryItem_Click(object sender, EventArgs e)
        {
            if (id_Update == null)
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
            string сategory = TextBox_Category.Text;
            if (сategory.Length == 0)
            {
                MessageBox.Show("Текстовое поле 'Категория' пустое");
                return;
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_Сategory = new OleDbCommand("INSERT INTO Список_КатегорияТовара (Категория) VALUES (?)", connection);

            command_Insert_Сategory.Parameters.Add(@сategory, OleDbType.VarChar).Value = сategory;

            dataAdapter.InsertCommand = command_Insert_Сategory;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void UpdateFunc()
        {
            string сategory = TextBox_Category.Text;
            string id = id_Update;

            if (сategory.Length == 0)
            {
                MessageBox.Show("Текстовое поле 'Категория' пустое");
                return;
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Update_Сategory = new OleDbCommand("UPDATE Список_КатегорияТовара SET Категория = ? WHERE id = ?", connection);

            command_Update_Сategory.Parameters.Add(сategory, OleDbType.VarChar).Value = сategory;
            command_Update_Сategory.Parameters.Add(id, OleDbType.Integer).Value = id;

            dataAdapter.UpdateCommand = command_Update_Сategory;

            connection.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void Form_AddUpd_CategoryItem_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.UpdateTable_Func();
        }
    }
}
