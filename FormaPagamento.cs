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
    public partial class FormaPagamento : Form

    {

        private novaCompra _funcao;

        public FormaPagamento(novaCompra novaCompra)
        {
            InitializeComponent();

            _funcao = novaCompra;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormaPagamento_Load(object sender, EventArgs e)
        {

            trocoTXT.Visible = false;
            trocoLabel.Visible = false;

        }

        private void pagamentoCBO_SelectedIndexChanged(object sender, EventArgs e)
        {

            trocoTXT.Visible = false;
            trocoLabel.Visible = false;

            if (pagamentoCBO.SelectedItem == "Dinheiro")
            {

                trocoLabel.Visible = true;
                trocoTXT.Visible = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int valor;
            int pagou;
            int resultado;
            

            novaCompra.pagamento = pagamentoCBO.Text;
           

            if (pagamentoCBO.SelectedItem == "Dinheiro")
            {


                Int32.TryParse(novaCompra.troco, out valor);
                Int32.TryParse(trocoTXT.Text, out pagou);

               


                resultado = pagou - valor;
                
                novaCompra.troco = resultado.ToString("C");
                _funcao.LabelTroco();

                    
            }

            string sql = "update venda set valor_venda = '"+ novaCompra.troco+ "' where ID_venda = '"+novaCompra.venda+"'" ;

            
            _funcao.LabelPagamento();
            this.Close();


        }
    }
}
