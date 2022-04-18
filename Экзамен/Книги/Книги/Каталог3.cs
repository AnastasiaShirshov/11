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
    public partial class Каталог3 : Form
    {
        public Каталог3()
        {
            InitializeComponent();
        }

        private void Каталог3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.knDataSet.Books);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Корзина y = new Корзина();
            y.Show();
        }
    }
}
