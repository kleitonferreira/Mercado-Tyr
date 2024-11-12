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

namespace SoftwareMercado
{
    public partial class AdicionarProduto : Form
    {
        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        string strConexao = MDI.strConexao;

        private void button1_Click(object sender, EventArgs e)
        {

            string quantidade = QNTDprodutoTXT.Text;
            string produto = NomeProdutoTXT.Text;
            bool QTNDnumero = int.TryParse(quantidade, out int resultado);
            bool txtnumero =  int.TryParse(produto, out resultado);


            if (QTNDnumero && !txtnumero) {

                string sql = "insert into produto" +
                    "(Nome_Produto,quantidade_produto)" +
                    "values" +
                    "('" + produto + "','" + quantidade + "')";

                MySqlConnection conexao = new MySqlConnection(strConexao);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;
                conexao.Open();


                try
                {

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0) {

                        MessageBox.Show("Produto Cadastrado com Sucesso!");
                        QNTDprodutoTXT.Text = "";
                        NomeProdutoTXT.Text = "";
                    
                    }

                }
                catch (Exception ex) 
                {

                    MessageBox.Show(ex.Message + "erro: produtos nao cadastrados!");

                }
                finally
                {

                    conexao.Close();
                }

            }
            else
            {

                MessageBox.Show("Nome do Produto ou quantidade Invalidas!");

            }

        }
    }
}
