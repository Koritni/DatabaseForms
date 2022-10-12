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
    public partial class Form_AddUpd_Item : Form
    {
        public Form_AddUpd_Item()
        {
            InitializeComponent();
            FillComboBoxes();
            ComboBox_Category.SelectedIndex = 0;
            ComboBox_Trademark.SelectedIndex = 0;
        }

        private string id_Update = null;

        public Form_AddUpd_Item(string id, string name, string amount, string id_Trademark, string id_Category, string money)
        {
            InitializeComponent();
            FillComboBoxes();
            Button_Add.Text = "Обновить";
            id_Update = id;
            TextBox_Name.Text = name;
            Numeric_Amount.Value = int.Parse(amount);
            ComboBox_Category.SelectedValue = int.Parse(id_Category);
            ComboBox_Trademark.SelectedValue = int.Parse(id_Trademark);
            TextBox_Money.Text = money;
        }

        private void Button_Add_Click(object sender, EventArgs e)
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

        //Вставить в таблицу
        private void InsertFunc()
        {
            string name = TextBox_Name.Text;
            string amount = Numeric_Amount.Value.ToString();
            string idCategory = ComboBox_Trademark.SelectedValue.ToString();
            string idTrademark = ComboBox_Category.SelectedValue.ToString();
            string money = TextBox_Money.Text;

            if (!CheckData(name,money))
            {
                return;
            }

            money = string.Format("{0:f}", double.Parse(money));

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_Item = new OleDbCommand("INSERT INTO Товар (Название, Количество, id_ТорговаяМарка, id_Категория, Цена) VALUES (?,?,?,?,?)", connection);

            command_Insert_Item.Parameters.Add(name, OleDbType.VarChar).Value = name;
            command_Insert_Item.Parameters.Add(amount, OleDbType.Integer).Value = amount;
            command_Insert_Item.Parameters.Add(idCategory, OleDbType.Integer).Value = idCategory;
            command_Insert_Item.Parameters.Add(idTrademark, OleDbType.Integer).Value = idTrademark;
            command_Insert_Item.Parameters.Add(money, OleDbType.Double).Value = money;
            dataAdapter.InsertCommand = command_Insert_Item;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        //Обновить в таблице
        private void UpdateFunc()
        {
            string name = TextBox_Name.Text;
            string amount = Numeric_Amount.Value.ToString();
            string idCategory = ComboBox_Trademark.SelectedValue.ToString();
            string idTrademark = ComboBox_Category.SelectedValue.ToString();
            string money = TextBox_Money.Text;
            string id = id_Update;

            if (!CheckData(name, money))
            {
                return;
            }

            money = string.Format("{0:f}", double.Parse(money));

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Update_Item = new OleDbCommand("UPDATE Товар SET Название = ?, Количество = ?, id_ТорговаяМарка = ?, id_Категория = ?, Цена = ? WHERE id = ?", connection);

            command_Update_Item.Parameters.Add(name, OleDbType.VarChar).Value = name;
            command_Update_Item.Parameters.Add(amount, OleDbType.Integer).Value = amount;
            command_Update_Item.Parameters.Add(idCategory, OleDbType.Integer).Value = idCategory;
            command_Update_Item.Parameters.Add(idTrademark, OleDbType.Integer).Value = idTrademark;
            command_Update_Item.Parameters.Add(id, OleDbType.Integer).Value = id;
            command_Update_Item.Parameters.Add(money, OleDbType.Double).Value = money;
            dataAdapter.UpdateCommand = command_Update_Item;

            connection.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        //Заполняем ComboBoxes данными из базы данных
        private void FillComboBoxes()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            DataSet dataSet_Trademark = new DataSet();
            OleDbCommand SelectQuery_Trademark = new OleDbCommand("SELECT id, Название FROM Список_ТорговаяМарка", connection);

            dataAdapter.SelectCommand = SelectQuery_Trademark;
            dataAdapter.Fill(dataSet_Trademark);


            ComboBox_Trademark.DataSource = dataSet_Trademark.Tables[0];
            ComboBox_Trademark.DisplayMember = "Название";
            ComboBox_Trademark.ValueMember = "id";

            OleDbCommand SelectQuery_Category = new OleDbCommand("SELECT id, Категория FROM Список_КатегорияТовара", connection);
            DataSet dataSet_Category = new DataSet();

            dataAdapter.SelectCommand = SelectQuery_Category;
            dataAdapter.Fill(dataSet_Category);

            ComboBox_Category.DataSource = dataSet_Category.Tables[0];
            ComboBox_Category.DisplayMember = "Категория";
            ComboBox_Category.ValueMember = "id";
        }

        private bool CheckData(string name, string money)
        {
            if(name.Length == 0)
            {
                MessageBox.Show("Поле 'Название' должно содержать в себе символы");
                return false;
            }
            else if (!double.TryParse(money, out double tryMoney) || tryMoney < 0)
            {
                MessageBox.Show("Поле 'Цена' содержит некоректные данные");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Numeric_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) //8 - Backspace
            {
                e.Handled = true;
            }
        }

        //При закрытии формы, обновлять DataGridView
        private void Form_AppUpd_Item_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.UpdateTable_Func();
        }

        //Не вводить буквы и лишние символы
        private void TextBox_Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) //8 - Backspace, 46 - Точка
            {
                e.Handled = true;
            }
        }
    }
}
