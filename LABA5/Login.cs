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
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        private string text = String.Empty;
        private int count = 0;
        private Timer timer;
        int remaning;
        int time = 180;

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            changeCapcha.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            label4.Visible = false;
            remaning = 60;
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {

            count++;
            var login = textBox_login.Text;
            var pwd = textBox_pwd.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string queryString = $"select id, login, password from users " +
                $"where login = '{login}' and password = '{pwd}'";



            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataBase.openConnection();
            string history = $"insert into history(id_user, _time, successful)";
            if (table.Rows.Count != 1)
            {
                history += $" values (NULL, '{DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss")}', 'false')";
            }
            else
            {
                history += $" values ({table.Rows[0].ItemArray[0].ToString()}, '{DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss")}', 'true')";
            }
            SqlCommand his = new SqlCommand(history, dataBase.getConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = his;
            his.ExecuteNonQuery();

            if (table.Rows.Count == 1)
            {

                MessageBox.Show("Вы успешно вошли", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainWindow mWindow = new MainWindow();
                this.Hide();
                mWindow.ShowDialog();
                this.Show();
                count = 0;

            }
            else
            {

                MessageBox.Show("Не получилось", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            label3.Text = $"Количество попыток {count}/3";
            if (count == 1)
            {
                changeCapcha.Visible = true;
                button_Enter.Visible = false;
                textBox1.Visible = true;
                textBox_login.Enabled = false;
                textBox_pwd.Enabled = false;
                button2.Visible = true;
                textBox_login.Text = "Введите CAPTCHA!!!";
                textBox_pwd.Text = "Введите CAPTCHA!!!";
                capchaImage.Image = this.CreateImage(capchaImage.Width, capchaImage.Height);
            }
            if (count == 2)
            {
                label4.Visible = true;
                timer1.Start();
                textBox_login.Enabled = false;
                textBox_pwd.Enabled = false;
                button_Enter.Enabled = false;

            }
            if (count == 3)
            {
                Application.Exit();
            }
        }

        private void passHide(object sender, EventArgs e)
        {
            textBox_pwd.PasswordChar = '•';
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage(result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            //for (int i = 0; i < Width; ++i)
            //    for (int j = 0; j < Height; ++j)
            //        if (rnd.Next() % 20 == 0)
            //            result.SetPixel(i, j, Color.White);

            return result;
        }

        private void changeCapcha_Click(object sender, EventArgs e)
        {
            capchaImage.Image = CreateImage(capchaImage.Width, capchaImage.Height);
        }
        private void inputCapcha(object sender, EventArgs e)
        {
            if (textBox1.Text == this.text)
            {
                MessageBox.Show("Верно!");
                textBox_login.Enabled = true;
                textBox_pwd.Enabled = true;
                textBox_login.Text = "";
                textBox_pwd.Text = "";
                button_Enter.Visible = true;
                changeCapcha.Visible = false;
                textBox1.Visible = false;
                button2.Visible = false;
                capchaImage.Visible = false;
            }
            else
            {
                MessageBox.Show("ERROR!!!");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label4.Text = $"Осталось: {time}";
            if (time == 0)
            {
                timer1.Stop();
                textBox_login.Enabled = true;
                textBox_pwd.Enabled = true;
                button_Enter.Enabled = true;
                MessageBox.Show("Время закончилось!!!");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                signUp sign_Up = new signUp();
                this.Hide();
                sign_Up.ShowDialog();
                this.Show();
            }
        }
    }
}
