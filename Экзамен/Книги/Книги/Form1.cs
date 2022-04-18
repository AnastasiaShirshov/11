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

namespace Книги
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            baza();

        }
        public static void con(out SqlConnection dbConnection)
        {
            string ConnStr = "Data Source=LAPTOP-F4IOAFVC;Initial Catalog=Экзамен01.01;Integrated Security=True";
            dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void baza()
        {
            SqlConnection dbConnection;
            string ConnStr = @"Data Source=LAPTOP-F4IOAFVC\Q;Initial Catalog=Apteka;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand comand = new SqlCommand("select * from Книги");
            da.SelectCommand = comand;
           


        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Корзина y = new Корзина();
            y.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Каталог2 y = new Каталог2();
            y.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Каталог3 t = new Каталог3();
            t.Show();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Книга добавлена в корзину");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Книга добавлена в корзину");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Книга добавлена в корзину");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Книга добавлена в корзину");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
