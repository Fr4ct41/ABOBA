namespace LABA5
{
    partial class Items
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.textBox_Cost = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(616, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Найти";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(674, 13);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(132, 22);
            this.textBox_Search.TabIndex = 30;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Update.Location = new System.Drawing.Point(616, 210);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(89, 79);
            this.button_Update.TabIndex = 29;
            this.button_Update.Text = "Обновить таблицу";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Save.Location = new System.Drawing.Point(456, 474);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(152, 47);
            this.button_Save.TabIndex = 28;
            this.button_Save.Text = "Сохранить запись";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Change.Location = new System.Drawing.Point(456, 420);
            this.button_Change.Margin = new System.Windows.Forms.Padding(4);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(152, 47);
            this.button_Change.TabIndex = 27;
            this.button_Change.Text = "Изменить запись";
            this.button_Change.UseVisualStyleBackColor = false;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Del
            // 
            this.button_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Del.Location = new System.Drawing.Point(456, 366);
            this.button_Del.Margin = new System.Windows.Forms.Padding(4);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(152, 47);
            this.button_Del.TabIndex = 26;
            this.button_Del.Text = "Удалить запись";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_New.Location = new System.Drawing.Point(456, 312);
            this.button_New.Margin = new System.Windows.Forms.Padding(4);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(152, 47);
            this.button_New.TabIndex = 25;
            this.button_New.Text = "Новая запись";
            this.button_New.UseVisualStyleBackColor = false;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(73, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id Мастерской";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(66, 454);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Стоимость товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(153, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(208, 420);
            this.textBox_Count.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(132, 22);
            this.textBox_Count.TabIndex = 20;
            // 
            // textBox_Cost
            // 
            this.textBox_Cost.Location = new System.Drawing.Point(208, 454);
            this.textBox_Cost.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Cost.Name = "textBox_Cost";
            this.textBox_Cost.Size = new System.Drawing.Size(132, 22);
            this.textBox_Cost.TabIndex = 19;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(208, 375);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 22);
            this.textBox_Name.TabIndex = 18;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(208, 343);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(132, 22);
            this.textBox_ID.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(595, 276);
            this.dataGridView1.TabIndex = 16;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LABA5.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_Cost);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Tovars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.TextBox textBox_Cost;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}