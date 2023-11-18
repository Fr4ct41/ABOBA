namespace LABA5
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.changeCapcha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.capchaImage = new System.Windows.Forms.PictureBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.capchaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(375, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "ВРЕМЯ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(445, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Ввести";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.inputCapcha);
            // 
            // changeCapcha
            // 
            this.changeCapcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.changeCapcha.Location = new System.Drawing.Point(586, 209);
            this.changeCapcha.Margin = new System.Windows.Forms.Padding(4);
            this.changeCapcha.Name = "changeCapcha";
            this.changeCapcha.Size = new System.Drawing.Size(133, 42);
            this.changeCapcha.TabIndex = 20;
            this.changeCapcha.Text = "Поменять картинку";
            this.changeCapcha.UseVisualStyleBackColor = false;
            this.changeCapcha.Click += new System.EventHandler(this.changeCapcha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 278);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(81, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(182, 414);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Зарегистрироваться";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // capchaImage
            // 
            this.capchaImage.BackColor = System.Drawing.Color.Transparent;
            this.capchaImage.Location = new System.Drawing.Point(445, 209);
            this.capchaImage.Margin = new System.Windows.Forms.Padding(4);
            this.capchaImage.Name = "capchaImage";
            this.capchaImage.Size = new System.Drawing.Size(133, 62);
            this.capchaImage.TabIndex = 12;
            this.capchaImage.TabStop = false;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(165, 250);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(132, 22);
            this.textBox_pwd.TabIndex = 16;
            this.textBox_pwd.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(81, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(81, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(165, 209);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(132, 22);
            this.textBox_login.TabIndex = 13;
            this.textBox_login.Text = "admin";
            // 
            // button_Enter
            // 
            this.button_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Enter.Location = new System.Drawing.Point(165, 335);
            this.button_Enter.Margin = new System.Windows.Forms.Padding(4);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(184, 75);
            this.button_Enter.TabIndex = 11;
            this.button_Enter.Text = "Войти";
            this.button_Enter.UseVisualStyleBackColor = false;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LABA5.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(799, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changeCapcha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.capchaImage);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_Enter);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.passHide);
            ((System.ComponentModel.ISupportInitialize)(this.capchaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button changeCapcha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox capchaImage;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Timer timer1;
    }
}

