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
    public partial class Form_AddUpd_Worker : Form
    {
        public Form_AddUpd_Worker()
        {
            InitializeComponent();
            BirthdayDate.MaxDate = DateTime.Now;
            Button_Add.Text = "Добавить";
        }

        private string id_Update = null;
        public Form_AddUpd_Worker(string id, string LastName, string Name, string Patronymic, string BirthdayDateStr, string PassportNumber, string Money)
        {
            InitializeComponent();
            id_Update = id;
            TextBox_LastName.Text = LastName;
            TextBox_Name.Text = Name;
            TextBox_Patronymic.Text = Patronymic;
            BirthdayDate.Value = System.DateTime.Parse(BirthdayDateStr);
            TextBox_PassportNumber.Text = PassportNumber;
            TextBox_Money.Text = Money;
            Button_Add.Text = "Обновить";
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
        private OleDbConnection connection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");

        private void UpdateFunc()
        {
            string id = id_Update;
            string Name = TextBox_Name.Text;
            string LastName = TextBox_LastName.Text;
            string Patronymic = TextBox_Patronymic.Text;
            string BirthdayDateStr = BirthdayDate.Value.ToString("MM-dd-yyyy");
            string PassportNumber = TextBox_PassportNumber.Text;
            string Money = TextBox_Money.Text;
            if (!Check_Data(Name, LastName, PassportNumber, Money))
            {
                return;
            }

            Money = string.Format("{0:f}", double.Parse(Money));

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Update_Worker = new OleDbCommand("Update Сотрудник SET Фамилия = ?, Имя = ?, Отчество = ?, Дата_рождения = ?, Номер_Паспорта = ?, Зарплата = ? WHERE id = ?", connection);
            command_Update_Worker.Parameters.Add(LastName, OleDbType.VarChar).Value = LastName;
            command_Update_Worker.Parameters.Add(Name, OleDbType.VarChar).Value = Name;
            command_Update_Worker.Parameters.Add(Patronymic, OleDbType.VarChar).Value = Patronymic;
            command_Update_Worker.Parameters.Add(BirthdayDateStr, OleDbType.Date).Value = BirthdayDateStr;
            command_Update_Worker.Parameters.Add(PassportNumber, OleDbType.VarChar).Value = PassportNumber;
            command_Update_Worker.Parameters.Add(Money, OleDbType.Double).Value = Money;
            command_Update_Worker.Parameters.Add(id, OleDbType.Integer).Value = id;
            dataAdapter.UpdateCommand = command_Update_Worker;

            connection.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            

            this.Close();
        }

        private void InsertFunc()
        {
            string Name = TextBox_Name.Text;
            string LastName = TextBox_LastName.Text;
            string Patronymic = TextBox_Patronymic.Text;
            string BirthdayDateStr = BirthdayDate.Value.ToString("MM-dd-yyyy");
            string PassportNumber = TextBox_PassportNumber.Text;
            string Money = TextBox_Money.Text;


            //Обработка исключений
            if (!Check_Data(Name, LastName, PassportNumber, Money))
            {
                return;
            }

            Money = string.Format("{0:f}", double.Parse(Money));

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_Worker = new OleDbCommand("INSERT INTO Сотрудник (Фамилия, Имя, Отчество, Дата_рождения, Номер_Паспорта, Зарплата) VALUES (?,?,?,?,?,?)", connection);

            command_Insert_Worker.Parameters.Add(@LastName, OleDbType.VarChar).Value = LastName;
            command_Insert_Worker.Parameters.Add(@Name, OleDbType.VarChar).Value = Name;
            command_Insert_Worker.Parameters.Add(@Patronymic, OleDbType.VarChar).Value = Patronymic;
            command_Insert_Worker.Parameters.Add(@BirthdayDateStr, OleDbType.Date).Value = BirthdayDateStr;
            command_Insert_Worker.Parameters.Add(@PassportNumber, OleDbType.VarChar).Value = PassportNumber;
            command_Insert_Worker.Parameters.Add(@Money, OleDbType.Double).Value = Money;
            dataAdapter.InsertCommand = command_Insert_Worker;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        //TODO: Переделать обработчик исключений
        private bool Check_Data(string name, string lastName, string passportNumber, string money)
        {
            if (name.Length == 0 || lastName.Length == 0)
            {
                MessageBox.Show("Поле 'Имя' или 'Фамилия' пустые");
                return false;
            }
            else if (passportNumber.Length != 11)
            {
                MessageBox.Show("Поле 'Номер паспорта' либо пустое, либо серия или номер введены не до конца");
                return false;
            }
            else if (!double.TryParse(money, out double tryMoney) || tryMoney < 0)
            {
                MessageBox.Show("Поле 'Зарплата' содержит некоректные данные");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void TextBox_Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) //8 - Backspace, 46 - Точка
            {
                e.Handled = true;
            }
        }

        private void Form_AddUpd_Worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.UpdateTable_Func();
            parentForm.FillComboBox();
        }
    }
}
