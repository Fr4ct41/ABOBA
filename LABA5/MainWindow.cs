using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA5
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_His_Click(object sender, EventArgs e)
        {
            History history = new History();
            Hide();
            history.ShowDialog();
        }

        private void button_Tov_List_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            Hide();
            items.ShowDialog();
        }
    }
}
