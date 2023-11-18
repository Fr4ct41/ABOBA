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
    public partial class History : Form
    {
        enum RowState
        { Existed, New, Modified, ModifiedNew, Deleted }

        DataBase dataBase = new DataBase();
        public History()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //DataGrid dataGrid;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("_time", "Время входа");
            dataGridView1.Columns.Add("successful", "1/0");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.IsDBNull(1) ? -1 : record.GetInt32(1), record.GetDateTime(2), record.GetBoolean(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string stringQuery = $"select * from history";

            SqlCommand cmd = new SqlCommand(stringQuery, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }


        private void History_Load(object sender, EventArgs e)
        {
            CreateColumns();

        }

        private void Del()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            Del();
        }
    }
}
