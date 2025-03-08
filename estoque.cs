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
    public partial class estoque : Form
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ADCproduto FRM = new ADCproduto();
            FRM.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ExcluirProduto FRM = new ExcluirProduto();
            FRM.ShowDialog();

        }

        private void estoque_Load(object sender, EventArgs e)
        {

            panelDisp.Visible = false;
            panelFalta.Visible = false;
            panelProd.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

            panelProd.Visible = true;
            panelDisp.Visible = false;
            panelFalta.Visible = false;

            carregarDataGridProduto();

        }

        string strConexao = MDI.strConexao;

        private void carregarDataGridProduto()
        {

            string sql = "select nome_produto as 'Nome',quantidade_produto as 'Quantidade', valor_produto as 'Preço' from produto";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {

                ad.Fill(ds);

                dataGridEstoque.DataSource = ds.Tables[0];
                dataGridEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridEstoque.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString);


            }
            finally
            {

                conexao.Close();

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

            panelProd.Visible = false;
            panelDisp.Visible = true;
            panelFalta.Visible = false;


            CarregarDataGridDisp();
        }

        private void CarregarDataGridDisp()
        {

            string sql = "select nome_produto as 'Nome',quantidade_produto as 'Quantidade', valor_produto as 'Preço' from produto " +
                "where quantidade_produto > 0";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {

                ad.Fill(ds);

                dataGridEstoque.DataSource = ds.Tables[0];
                dataGridEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridEstoque.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex);


            }
            finally
            {

                conexao.Close();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

            panelProd.Visible = false;
            panelDisp.Visible = false;
            panelFalta.Visible = true;
            CarregarDataGridFalta();


        }

        private void CarregarDataGridFalta()
        {

            string sql = "select nome_produto as 'Nome',quantidade_produto as 'Quantidade', valor_produto as 'Preço' from produto " +
                    "where quantidade_produto <= 0";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {

                ad.Fill(ds);

                dataGridEstoque.DataSource = ds.Tables[0];
                dataGridEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridEstoque.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex);


            }
            finally
            {

                conexao.Close();


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
