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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoftwareMercado
{
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
        }

        string strConexao = MDI.strConexao;

        private void historico_Load(object sender, EventArgs e)
        {

            Combo_operadores();

        }

        private void Combo_operadores()
        {

            string sql = "select ID_Usuario,Nome_Usuario from usuario";

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


                CBOidOperador.DisplayMember = "ID_usuario";
                CBOidOperador.ValueMember = "ID_usuario";
                CBOidOperador.DataSource = tabelaID;


                CBOoperador.DisplayMember = "Nome_usuario";
                CBOoperador.ValueMember = "ID_usuario";
                CBOoperador.DataSource = tabelaNome;

                CBOoperador.SelectedIndexChanged += (s, e) =>
                {

                    CBOidOperador.SelectedValue = CBOoperador.SelectedValue;

                };


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString + "erro ao carregar os operadores");

            }
            finally
            {

                conexao.Close();

            }

        }

        private void carregar_Datagridhist()
        {
           

            string Inicio = dateTimeInicio.Value.Date.ToString("yyyy-MM-dd");
            string Fim = dateTimeFim.Value.Date.ToString("yyyy-MM-dd");
            string dataInicio = Inicio.Replace("00:00:00", "");
            string dataFim = Fim.Replace("00:00:00", "");

            string sql = "SELECT venda.data_venda AS 'Data'," +
                "venda.status_venda AS 'Status'," +
                "itens_venda.nome_usuario_item AS 'Operador'," +
                "venda.pagamento_venda AS 'Pagamento'," +
                "venda.valor_venda AS 'Total'" +
                "FROM venda " +
                "INNER JOIN " +
                "itens_venda ON itens_venda.id_venda_item = venda.ID_venda " +
                "WHERE venda.data_venda BETWEEN '" + dataInicio + "' AND '" + dataFim + " '" +
                "and itens_venda.id_usuario_item = '" + CBOidOperador.Text + "'AND venda.status_venda = 'Iniciada'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            
            conexao.Open();

            try
            {
               

                ad.Fill(ds);

                dataGridHist.DataSource = ds.Tables[0];
                dataGridHist.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridHist.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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


        private void button1_Click(object sender, EventArgs e)
        {

            

            if (checkBox1.Checked == true)
            {
                decimal total = 0;

                dataGridHist.DataSource = null;
                dataGridHist.Rows.Clear();
                Pesquisa_canceladas();

                foreach (DataGridViewRow row in dataGridHist.Rows)
                {
                    if (row.Cells["total"].Value != null && row.Cells["total"].Value != DBNull.Value)
                    {
                        total += Convert.ToDecimal(row.Cells["total"].Value);
                    }
                }

                LBLtotal.Text = "Total: " + total.ToString("C");

            }
            if (checkBox2.Checked == true)
            {
                decimal total = 0;
                dataGridHist.DataSource = null;
                dataGridHist.Rows.Clear();
                Pesquisa_concluida();

                foreach (DataGridViewRow row in dataGridHist.Rows)
                {
                    if (row.Cells["total"].Value != null && row.Cells["total"].Value != DBNull.Value)
                    {
                        total += Convert.ToDecimal(row.Cells["total"].Value);
                    }
                }

                LBLtotal.Text = "Total: " + total.ToString("C");

            }
            if(checkBox1.Checked == false && checkBox2.Checked == false) 
            {
                decimal total = 0;

                dataGridHist.DataSource = null;
                dataGridHist.Rows.Clear();
                carregar_Datagridhist();

                foreach (DataGridViewRow row in dataGridHist.Rows)
                {
                    if (row.Cells["total"].Value != null && row.Cells["total"].Value != DBNull.Value)
                    {
                        total += Convert.ToDecimal(row.Cells["total"].Value);
                    }
                }

                LBLtotal.Text = "Total: " + total.ToString("C");

            }

          

        }

        private void Pesquisa_concluida()
        {
           
            checkBox1.Checked = false;

            string Inicio = dateTimeInicio.Value.Date.ToString("yyyy-MM-dd");
            string Fim = dateTimeFim.Value.Date.ToString("yyyy-MM-dd");
            string dataInicio = Inicio.Replace("00:00:00", "");
            string dataFim = Fim.Replace("00:00:00", "");

            string sql = "SELECT venda.data_venda AS 'Data'," +
                "venda.status_venda AS 'Status'," +
                "itens_venda.id_usuario_item AS 'Operador'," +
                "venda.pagamento_venda AS 'Pagamento'," +
                "venda.valor_venda AS 'Total'" +
                "FROM venda " +
                "INNER JOIN " +
                "itens_venda ON itens_venda.id_venda_item = venda.ID_venda " +
                "WHERE venda.data_venda BETWEEN '" + dataInicio + "' AND '" + dataFim + "' " +
                "AND venda.status_venda = 'Iniciada' and itens_venda.id_usuario_item = '" + CBOidOperador.Text + "'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conexao);
            
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {
                

                ad.Fill(ds);

                dataGridHist.DataSource = ds.Tables[0];
                dataGridHist.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridHist.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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

        private void Pesquisa_canceladas()
        {

            
            
            checkBox2.Checked = false;

            string Inicio = dateTimeInicio.Value.Date.ToString("yyyy-MM-dd");
            string Fim = dateTimeFim.Value.Date.ToString("yyyy-MM-dd");
            string dataInicio = Inicio.Replace("00:00:00", "");
            string dataFim = Fim.Replace("00:00:00", "");

            string sql = "SELECT venda.data_venda AS 'Data'," +
                "venda.status_venda AS 'Status'," +
                "itens_venda.id_usuario_item AS 'Operador'," +
                "venda.pagamento_venda AS 'Pagamento'," +
                "venda.valor_venda AS 'Total'" +
                "FROM venda " +
                "INNER JOIN " +
                "itens_venda ON itens_venda.id_venda_item = venda.ID_venda " +
                "WHERE venda.data_venda BETWEEN '" + dataInicio + "' AND '" + dataFim + "' AND venda.status_venda <> 'Iniciada'" +
                "and itens_venda.id_usuario_item = '" + CBOidOperador.Text + "'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {
                

                ad.Fill(ds);

                dataGridHist.DataSource = ds.Tables[0];
                dataGridHist.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridHist.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

               

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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            checkBox1.Checked = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }
    }
}
