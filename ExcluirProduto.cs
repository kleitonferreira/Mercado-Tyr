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
    public partial class ExcluirProduto : Form
    {
        public ExcluirProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void ExcluirProduto_Load(object sender, EventArgs e)
        {

            carregarComboProduto();

        }

        string strConexao = MDI.strConexao;

        private void carregarComboProduto()
        {

            string sql = "select ID_Produto, Nome_Produto from produto";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            conexao.Open();

            try
            {

                MySqlDataReader leitura = cmd.ExecuteReader();


                DataTable tabelaID = new DataTable();
                DataTable tabelaNome = new DataTable();


                tabelaID.Load(leitura);


                leitura.Close();
                leitura = cmd.ExecuteReader();
                tabelaNome.Load(leitura);


                CBOid.DisplayMember = "ID_Produto";
                CBOid.ValueMember = "ID_Produto";
                CBOid.DataSource = tabelaID;


                CBOprodutos.DisplayMember = "Nome_Produto";
                CBOprodutos.ValueMember = "ID_Produto";
                CBOprodutos.DataSource = tabelaNome;


                //Quando o usuário seleciona um item em CBOprodutos, o evento SelectedIndexChanged é disparado.
                //O manipulador de evento então executa o código dentro das chaves { ... }.
                //O valor SelectedValue de CBOprodutos é atribuído a CBOid.SelectedValue, sincronizando ambas as ComboBox pelo ID_Produto

                CBOprodutos.SelectedIndexChanged += (s, e) =>
                {

                    CBOid.SelectedValue = CBOprodutos.SelectedValue;

                };


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString + "erro ao carregar os produtos");

            }
            finally
            {

                conexao.Close();

            }


        }

        private void button1_Click(object sender, EventArgs e)

        {

            string sql = "delete from produto Where id_produto = " + CBOid.Text;

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
           
            conexao.Open();

            

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("produto deletado com sucesso");
                    carregarComboProduto();
                    CBOprodutos.Text = "";

                }

            
            }catch(Exception ex)
            {

                MessageBox.Show("erro:" + ex.ToString());

            }
            finally
            {

                conexao.Close() ;

            }


        }
    }
}
