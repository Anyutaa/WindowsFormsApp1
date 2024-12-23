namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_manufacture_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_valid_until_year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_link = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.text_manufacture_month = new System.Windows.Forms.TextBox();
            this.text_manufacture_day = new System.Windows.Forms.TextBox();
            this.text_valid_until_month = new System.Windows.Forms.TextBox();
            this.text_valid_until_day = new System.Windows.Forms.TextBox();
            this.add_button_2 = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 388);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(437, 307);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(164, 52);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить продукт";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название продукта";
            // 
            // text_name
            // 
            this.text_name.Enabled = false;
            this.text_name.Location = new System.Drawing.Point(469, 28);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(242, 22);
            this.text_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // text_price
            // 
            this.text_price.Enabled = false;
            this.text_price.Location = new System.Drawing.Point(469, 76);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(242, 22);
            this.text_price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата производства";
            // 
            // text_manufacture_year
            // 
            this.text_manufacture_year.Enabled = false;
            this.text_manufacture_year.Location = new System.Drawing.Point(469, 127);
            this.text_manufacture_year.Name = "text_manufacture_year";
            this.text_manufacture_year.Size = new System.Drawing.Size(67, 22);
            this.text_manufacture_year.TabIndex = 7;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Годен до";
            // 
            // text_valid_until_year
            // 
            this.text_valid_until_year.Enabled = false;
            this.text_valid_until_year.Location = new System.Drawing.Point(469, 174);
            this.text_valid_until_year.Name = "text_valid_until_year";
            this.text_valid_until_year.Size = new System.Drawing.Size(67, 22);
            this.text_valid_until_year.TabIndex = 9;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество";
            // 
            // text_quantity
            // 
            this.text_quantity.Enabled = false;
            this.text_quantity.Location = new System.Drawing.Point(469, 222);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.Size = new System.Drawing.Size(242, 22);
            this.text_quantity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ссылка";
            // 
            // text_link
            // 
            this.text_link.Enabled = false;
            this.text_link.Location = new System.Drawing.Point(469, 267);
            this.text_link.Name = "text_link";
            this.text_link.Size = new System.Drawing.Size(242, 22);
            this.text_link.TabIndex = 13;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(608, 377);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(164, 40);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Удалить продукт";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(437, 377);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(164, 40);
            this.edit_button.TabIndex = 16;
            this.edit_button.Text = "Отредактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(23, 5);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(147, 52);
            this.load_button.TabIndex = 17;
            this.load_button.Text = "Загрузить файл";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // text_manufacture_month
            // 
            this.text_manufacture_month.Enabled = false;
            this.text_manufacture_month.Location = new System.Drawing.Point(553, 127);
            this.text_manufacture_month.Name = "text_manufacture_month";
            this.text_manufacture_month.Size = new System.Drawing.Size(67, 22);
            this.text_manufacture_month.TabIndex = 19;
            // 
            // text_manufacture_day
            // 
            this.text_manufacture_day.Enabled = false;
            this.text_manufacture_day.Location = new System.Drawing.Point(644, 127);
            this.text_manufacture_day.Name = "text_manufacture_day";
            this.text_manufacture_day.Size = new System.Drawing.Size(67, 22);
            this.text_manufacture_day.TabIndex = 20;
            // 
            // text_valid_until_month
            // 
            this.text_valid_until_month.Enabled = false;
            this.text_valid_until_month.Location = new System.Drawing.Point(553, 176);
            this.text_valid_until_month.Name = "text_valid_until_month";
            this.text_valid_until_month.Size = new System.Drawing.Size(67, 22);
            this.text_valid_until_month.TabIndex = 21;
            // 
            // text_valid_until_day
            // 
            this.text_valid_until_day.Enabled = false;
            this.text_valid_until_day.Location = new System.Drawing.Point(644, 176);
            this.text_valid_until_day.Name = "text_valid_until_day";
            this.text_valid_until_day.Size = new System.Drawing.Size(67, 22);
            this.text_valid_until_day.TabIndex = 22;
            // 
            // add_button_2
            // 
            this.add_button_2.Location = new System.Drawing.Point(607, 307);
            this.add_button_2.Name = "add_button_2";
            this.add_button_2.Size = new System.Drawing.Size(164, 52);
            this.add_button_2.TabIndex = 23;
            this.add_button_2.Text = "Добавить онлайн продукт";
            this.add_button_2.UseVisualStyleBackColor = true;
            this.add_button_2.Click += new System.EventHandler(this.add_button_2_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(225, 5);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(164, 52);
            this.save_button.TabIndex = 24;
            this.save_button.Text = "Сохранить продукт";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.add_button_2);
            this.Controls.Add(this.text_valid_until_day);
            this.Controls.Add(this.text_valid_until_month);
            this.Controls.Add(this.text_manufacture_day);
            this.Controls.Add(this.text_manufacture_month);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.text_link);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_valid_until_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_manufacture_year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_manufacture_year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_valid_until_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_link;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.TextBox text_manufacture_month;
        private System.Windows.Forms.TextBox text_manufacture_day;
        private System.Windows.Forms.TextBox text_valid_until_month;
        private System.Windows.Forms.TextBox text_valid_until_day;
        private System.Windows.Forms.Button add_button_2;
        private System.Windows.Forms.Button save_button;
    }
}

