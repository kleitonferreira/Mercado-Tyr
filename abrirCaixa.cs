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
    public partial class abrirCaixa : Form
    {

        private MDI _funcao;

        public abrirCaixa(MDI MDI)
        {
            InitializeComponent();

           
            _funcao = MDI;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void abrirCaixa_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MDI.statusCaixa = "aberto";
            novaCompra.venda = "";

            if(MDI.tela == "Nova Compra")
            {

                _funcao.ClicarBotao1();


            }if(MDI.tela == "Estoque")
            {

                _funcao.ClicarBotao2();

            }if(MDI.tela == "Historico de vendas")
            {

                _funcao.ClicarBotao3();

            }

            this.Close();

        }

        
    }
}
