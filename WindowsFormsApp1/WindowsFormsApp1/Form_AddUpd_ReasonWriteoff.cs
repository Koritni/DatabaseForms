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
    public partial class Form_AddUpd_ReasonWriteoff : Form
    {
        public Form_AddUpd_ReasonWriteoff()
        {
            InitializeComponent();
        }

        private string id_Update = null;
        public Form_AddUpd_ReasonWriteoff(string id, string reason)
        {
            InitializeComponent();
            Button_Add_ReasonWriteOff.Text = "Обновить";
            id_Update = id;
            TextBox_Reason.Text = reason;
        }

        private void Button_Add_ReasonWriteOff_Click(object sender, EventArgs e)
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
            string reason = TextBox_Reason.Text;
            if (reason.Length == 0)
            {
                MessageBox.Show("Текстовое поле 'Причина' пустое");
                return;
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Insert_Reason = new OleDbCommand("INSERT INTO Список_ПричинаСписания (Причина) VALUES (?)", connection);

            command_Insert_Reason.Parameters.Add(reason, OleDbType.VarChar).Value = reason;

            dataAdapter.InsertCommand = command_Insert_Reason;

            connection.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
        private void UpdateFunc()
        {
            string reason = TextBox_Reason.Text;
            string id = id_Update;
            if (reason.Length == 0)
            {
                MessageBox.Show("Текстовое поле 'Причина' пустое");
                return;
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            OleDbCommand command_Update_Reason = new OleDbCommand("UPDATE Список_ПричинаСписания SET Причина = ? WHERE id = ?", connection);

            command_Update_Reason.Parameters.Add(reason, OleDbType.VarChar).Value = reason;
            command_Update_Reason.Parameters.Add(id, OleDbType.VarChar).Value = id;

            dataAdapter.UpdateCommand = command_Update_Reason;

            connection.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void Form_AddUpd_ReasonWriteoff_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            parentForm.UpdateTable_Func();
        }
    }
}
