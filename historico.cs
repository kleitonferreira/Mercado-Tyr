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
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
        }

        string strConexao = MDI.strConexao;

        private void historico_Load(object sender, EventArgs e)
        {

        }

        private void carregar_Datagridhist()
        {

            string Inicio = dateTimeInicio.Value.Date.ToString("yyyy-MM-dd");
            string Fim = dateTimeFim.Value.Date.ToString("yyyy-MM-dd");
            string dataInicio = Inicio.Replace("00:00:00", "");
            string dataFim = Fim.Replace("00:00:00", "");

            string sql = "SELECT venda.data_venda AS 'data'," +
                "venda.status_venda AS 'status'," +
                "itens_venda.id_usuario_item AS 'operador'," +
                "venda.pagamento_venda AS 'Pagamento'," +
                "venda.valor_venda AS 'total'" +
                "FROM venda " +
                "INNER JOIN " +
                "itens_venda ON itens_venda.id_venda_item = venda.ID_venda " +
                "WHERE venda.data_venda BETWEEN '"+dataInicio+"' AND '"+dataFim+"'";

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

            carregar_Datagridhist();
            
            
        }
    }
}
