using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Книги
{
    public partial class Каталог2 : Form
    {
        public Каталог2()
        {
            InitializeComponent();
        }

        private void Каталог2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Корзина y = new Корзина();
            y.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            y.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            y.Show();
        }
    }
}
