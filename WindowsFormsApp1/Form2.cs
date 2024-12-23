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
            var edit_product = new Product();
            GetProduct(ref edit_product, param);
            edit_product.Name_product = text_name.Text;
            edit_product.Price = Convert.ToDouble(text_price.Text);
            edit_product.ManufactureYear = Convert.ToInt32(text_manufacture_year.Text);
            edit_product.ManufactureMonth = Convert.ToInt32(text_manufacture_month.Text);
            edit_product.ManufactureDay = Convert.ToInt32(text_manufacture_day.Text);
            edit_product.ValidUntilYear = Convert.ToInt32(text_valid_until_year.Text);
            edit_product.ValidUntilMonth = Convert.ToInt32(text_valid_until_month.Text);
            edit_product.ValidUntilDay = Convert.ToInt32(text_valid_until_day.Text);
            edit_product.Quantity = Convert.ToInt32(text_quantity.Text);
            if (param_edit_or_add == 2)
            {
                if (string.IsNullOrEmpty(text_link.Text))
                {
                    MessageBox.Show("У онлайн продукта должна быть ссылка.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
