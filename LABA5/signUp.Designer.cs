namespace LABA5
{
    partial class signUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sign_up = new System.Windows.Forms.Button();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sign_up
            // 
            this.button_sign_up.Location = new System.Drawing.Point(59, 134);
            this.button_sign_up.Margin = new System.Windows.Forms.Padding(4);
            this.button_sign_up.Name = "button_sign_up";
            this.button_sign_up.Size = new System.Drawing.Size(163, 62);
            this.button_sign_up.TabIndex = 15;
            this.button_sign_up.Text = "Зарегистрироваться";
            this.button_sign_up.UseVisualStyleBackColor = true;
            this.button_sign_up.Click += new System.EventHandler(this.button_sign_up_Click);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(93, 75);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(161, 22);
            this.textBox_pwd.TabIndex = 14;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(93, 43);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(161, 22);
            this.textBox_login.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин";
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 217);
            this.Controls.Add(this.button_sign_up);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signUp";
            this.Text = "signUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sign_up;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}