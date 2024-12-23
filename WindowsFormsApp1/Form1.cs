using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using static WindowsFormsApp1.Form1;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Product
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Name_product;

            [MarshalAs(UnmanagedType.R8)]
            public double Price;

            [MarshalAs(UnmanagedType.I4)]
            public int ManufactureYear;

            [MarshalAs(UnmanagedType.I4)]
            public int ManufactureMonth;

            [MarshalAs(UnmanagedType.I4)]
            public int ManufactureDay;

            [MarshalAs(UnmanagedType.I4)]
            public int ValidUntilYear;

            [MarshalAs(UnmanagedType.I4)]
            public int ValidUntilMonth;

            [MarshalAs(UnmanagedType.I4)]
            public int ValidUntilDay;

            [MarshalAs(UnmanagedType.I4)]
            public int Quantity;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Link_product;
        }

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern int GetSize();

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void Load(string filename);

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void AddProduct(int param);

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void Save(string filename);

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void GetProduct(ref Product product, int id);


        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern bool DeleteProduct(int id);

        [DllImport(@"C:\Users\user\Documents\GitHub\c#_lab6\WindowsFormsApp1\x64\Debug\DLL_Smirnova.dll", CharSet = CharSet.Ansi)]
        public static extern void Clear();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = new Product();
            GetProduct(ref product, listBox1.SelectedIndex);
            
            text_name.Text = product.Name_product;
            text_price.Text = product.Price.ToString();
            text_manufacture_year.Text = product.ManufactureYear.ToString();
            text_manufacture_month.Text = product.ManufactureMonth.ToString();
            text_manufacture_day.Text = product.ManufactureDay.ToString();
            text_valid_until_year.Text = product.ValidUntilYear.ToString();
            text_valid_until_month.Text = product.ValidUntilMonth.ToString();
            text_valid_until_day.Text = product.ValidUntilDay.ToString();
            text_quantity.Text = product.Quantity.ToString();


            if (!string.IsNullOrEmpty(product.Link_product))
            {
                text_link.Text = product.Link_product;
                label6.Visible = true;
                text_link.Visible = true;
            }
            else
            {
                label6.Visible = false;
                text_link.Visible = false;
            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите продукт для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DeleteProduct(listBox1.SelectedIndex))
            {
                int beforeDelete = listBox1.SelectedIndex;
                UpdateListBox();
                if (beforeDelete != listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = beforeDelete;
                }
                else
                {
                    listBox1.SelectedIndex = beforeDelete - 1;
                }
            }
            if (GetSize() == 0)
            {
                text_name.Text = "";
                text_price.Text = "";
                text_manufacture_year.Text = "";
                text_manufacture_month.Text = "";
                text_manufacture_day.Text = "";
                text_valid_until_year.Text = "";
                text_valid_until_month.Text = "";
                text_valid_until_day.Text = "";
                text_quantity.Text = "";
                text_link.Text = "";
                return;
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                Load(filename);
                UpdateListBox();
            }
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < GetSize(); i++)
            {
                var product = new Product();
                GetProduct(ref product, i);
                listBox1.Items.Add(product.Name_product);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddProduct(0);
            int selected = GetSize()-1;
            Form2 newForm = new Form2(selected,1);
            newForm.ShowDialog();
            UpdateListBox();


        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            
            int selected = listBox1.SelectedIndex;
            Form2 newForm = new Form2(selected,0);
            newForm.ShowDialog();
            UpdateListBox();

        }

        private void add_button_2_Click(object sender, EventArgs e)
        {
            AddProduct(1);
            int selected = GetSize() - 1;
            Form2 newForm = new Form2(selected,2);
            newForm.ShowDialog();
            UpdateListBox();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                Save(filename);
            }
        }
        
    }
}
