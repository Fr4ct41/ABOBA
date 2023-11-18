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
    public partial class Items : Form
    {
        DataBase dataBase = new DataBase();
        int SelectRow;
        enum RowState
        { Existed, New, Modified, ModifiedNew, Deleted }
        public Items()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Название");
            dataGridView1.Columns.Add("count", "Мастерская");
            dataGridView1.Columns.Add("cost", "Стоимость");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2),record.GetDouble(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string stringQuery = $"select * from products";

            SqlCommand cmd = new SqlCommand(stringQuery, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        private void Tovars_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectRow];


                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Count.Text = row.Cells[2].Value.ToString();
                textBox_Cost.Text = row.Cells[3].Value.ToString();



            }


        }

        private void button_New_Click(object sender, EventArgs e)
        {
            NewItem newTovarcs = new NewItem();
            newTovarcs.Show();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from products" +
                $" where concat (id, name, workshop_id, price) like '%" + textBox_Search.Text + "%'";

            SqlCommand cmd = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();

        }


        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }


        private void Del()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;

                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;

        }

        private void Up()
        {
            dataBase.openConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[4].Value;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    var deleteQuery = $"delete from products where id = {id}";


                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var cost = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var count = dataGridView1.Rows[i].Cells[3].Value.ToString();


                    var query = $"update products set name = '{name}', price='{cost}',workshop_id='{count}' where id = '{id}'";


                    var command = new SqlCommand(query, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            Del();
            ClearFields();
        }



        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var name = textBox_Name.Text;
            var count = textBox_Count.Text;
            decimal cost;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_Cost.Text, out cost))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, cost, count);
                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена указана не верно!!!");
                }
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Up();
        }


        private void ClearFields()
        {
            textBox_ID.Text = "";
            textBox_Name.Text = "";
            textBox_Cost.Text = "";
            textBox_Count.Text = "";
        }
    }
}

