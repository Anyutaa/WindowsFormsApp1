using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private int param;
        private int param_edit_or_add;
        public Form2(int param,int param_edit_or_add)
        {
            InitializeComponent();
            this.param = param;
            this.param_edit_or_add = param_edit_or_add;
            var product = new Product();
            GetProduct(ref product, param);
            text_name.Text = product.Name_product;
            text_price.Text = product.Price.ToString();
            text_manufacture_year.Text = product.ManufactureYear.ToString();
            text_manufacture_month.Text = product.ManufactureMonth.ToString();
            text_manufacture_day.Text = product.ManufactureDay.ToString();
            text_valid_until_year.Text = product.ValidUntilYear.ToString();
            text_valid_until_month.Text = product.ValidUntilMonth.ToString();
            text_valid_until_day.Text = product.ValidUntilDay.ToString();
            text_quantity.Text = product.Quantity.ToString();
            if (param_edit_or_add == 1)
            {
                label6.Visible = false;
                text_link.Visible = false;
            }
            else if (param_edit_or_add == 2)
            {
                checkBox1.Checked = true;
                text_link.Visible = true;
                text_link.Text = product.Link_product;
            }
            if (param_edit_or_add == 0) { 
                    if (!string.IsNullOrEmpty(product.Link_product))
                {
                    checkBox1.Checked = true;
                    text_link.Text = product.Link_product;
                    label6.Visible = true;
                    text_link.Visible = true;
                }
                else
                {
                    label6.Visible = false;
                    text_link.Visible = false;}
            }


        }

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void UpdateProduct(ref Product product, int id);

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void AddProduct(int param);


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_name.Text) ||
                string.IsNullOrEmpty(text_price.Text) ||
                string.IsNullOrEmpty(text_manufacture_year.Text) ||
                string.IsNullOrEmpty(text_manufacture_month.Text) ||
                string.IsNullOrEmpty(text_manufacture_day.Text) ||
                string.IsNullOrEmpty(text_valid_until_year.Text) ||
                string.IsNullOrEmpty(text_valid_until_month.Text) ||
                string.IsNullOrEmpty(text_valid_until_day.Text) ||
                string.IsNullOrEmpty(text_quantity.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(text_price.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Цена должна быть положительным числом больше 0.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(text_manufacture_year.Text, out int manufactureYear) ||
                !int.TryParse(text_manufacture_month.Text, out int manufactureMonth) ||
                !int.TryParse(text_manufacture_day.Text, out int manufactureDay))
            {
                MessageBox.Show("Дата производства должна быть введена корректно.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(text_valid_until_year.Text, out int validUntilYear) ||
                !int.TryParse(text_valid_until_month.Text, out int validUntilMonth) ||
                !int.TryParse(text_valid_until_day.Text, out int validUntilDay))
            {
                MessageBox.Show("Дата срока годности должна быть введена корректно.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(text_quantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Количество должно быть положительным целым числом больше 0.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на корректность значений даты производства
            if (manufactureMonth < 1 || manufactureMonth > 12)
            {
                MessageBox.Show("Месяц производства должен быть в диапазоне от 1 до 12.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (manufactureYear < 1999 || manufactureYear > 2024)
            {
                MessageBox.Show("Год производства должен быть в диапазоне от 1999 до 2024 включительно.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (manufactureDay < 1 || manufactureDay > DateTime.DaysInMonth(manufactureYear, manufactureMonth))
            {
                MessageBox.Show("День производства введён некорректно.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime manufactureDate = new DateTime(manufactureYear, manufactureMonth, manufactureDay);
            if (manufactureDate > DateTime.Today)
            {
                MessageBox.Show("Дата производства не может быть позже сегодняшнего дня.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (validUntilMonth < 1 || validUntilMonth > 12)
            {
                MessageBox.Show("Месяц срока годности должен быть в диапазоне от 1 до 12.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (validUntilDay < 1 || validUntilDay > DateTime.DaysInMonth(validUntilYear, validUntilMonth))
            {
                MessageBox.Show("День срока годности введён некорректно.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime validUntilDate = new DateTime(validUntilYear, validUntilMonth, validUntilDay);
            if (validUntilDate <= manufactureDate)
            {
                MessageBox.Show("Дата срока годности должна быть позже даты производства.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var edit_product = new Product();
            GetProduct(ref edit_product, param);

            edit_product.Name_product = text_name.Text;
            edit_product.Price = price;
            edit_product.ManufactureYear = manufactureYear;
            edit_product.ManufactureMonth = manufactureMonth;
            edit_product.ManufactureDay = manufactureDay;
            edit_product.ValidUntilYear = validUntilYear;
            edit_product.ValidUntilMonth = validUntilMonth;
            edit_product.ValidUntilDay = validUntilDay;
            edit_product.Quantity = quantity;

            if (param_edit_or_add == 2)
            {
                if (string.IsNullOrEmpty(text_link.Text))
                {
                    MessageBox.Show("У онлайн продукта должна быть ссылка.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                edit_product.Link_product = text_link.Text;
            }

            UpdateProduct(ref edit_product, param);
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (param_edit_or_add == 2 || param_edit_or_add == 1)
            {
                DeleteProduct(param);
            }
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
