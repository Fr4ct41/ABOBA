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
    public partial class NewItem : Form
    {
        DataBase dataBase = new DataBase();
        public NewItem()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var name = textBox_Name.Text;
            var workshop_id = int.Parse(textBox_Count.Text);
            int cost;
            if (int.TryParse(textBox_Cost.Text, out cost))
            {
                var addQuery = $"insert into products (name, workshop_id, price) " +
                    $"values ('{name}','{workshop_id}','{cost}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();



                MessageBox.Show("Запись создана успешно!!!", "Успех!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена введена не правльно");
            }
            dataBase.closeConnection();



        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
