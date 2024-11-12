using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMercado
{
    public partial class estoque : Form
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdicionarProduto FRM = new AdicionarProduto();
            FRM.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ExcluirProduto FRM = new ExcluirProduto();
            FRM.ShowDialog();

        }
    }
}
