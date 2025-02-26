using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

namespace SoftwareMercado
{
    public partial class ADCproduto : Form
    {
        public ADCproduto()
        {
            InitializeComponent();
        }

        private void ADCproduto_Load(object sender, EventArgs e)
        {



        }

        string strConexao = MDI.strConexao;

        private void button1_Click(object sender, EventArgs e)
        {

            string quantidade = quantidadeTXT.Text;
            string valor = valorTXT.Text;

            valor = valor.Replace("R$ ", "");
            valor = valor.Replace(",", ".");

            bool qtdeEhnumero = int.TryParse(quantidade, out int qtde);
           

            if (qtdeEhnumero == true)
            {

                string sql = "insert into produto" +
                    "(Nome_Produto,quantidade_Produto,valor_produto)" +
                    "values" +
                    "('" + nomeTXT.Text + "','" + qtde + "','" + valor + "')";

                MySqlConnection conexao = new MySqlConnection(strConexao);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;
                conexao.Open();

                try
                {

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected > 0)
                    {

                        MessageBox.Show("Produto cadastrado com Sucesso");
                        nomeTXT.Text = "";
                        quantidadeTXT.Text = "";
                        valorTXT.Text = "";

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    conexao.Close();

                }

            }
            else
            {

                MessageBox.Show("quantidade e valor devem ser numeros!");

            }

        }

        private void valorTXT_Leave(object sender, EventArgs e)
        {

            float valor;

            if (float.TryParse(valorTXT.Text, out valor))
            {
                valorTXT.Text = valor.ToString("C");
            }
            else
            {

                valorTXT.Text = "";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
