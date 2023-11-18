using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LABA5
{
    public partial class signUp : Form
    {
        DataBase dataBase = new DataBase(); 
        public signUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button_sign_up_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var pwd = textBox_pwd.Text;

            string stringQuery = $"insert into users(login, password) " +
                $"values('{login}','{pwd}')";

            SqlCommand command = new SqlCommand(stringQuery, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!!!", "@@@");
                this.Close();
            }
            else
                MessageBox.Show("Аккаунт не создан!!!", "@@@");
            dataBase.closeConnection();

        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
