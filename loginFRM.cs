
using System.Security.Principal;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SoftwareMercado
{
    public partial class loginFRM : Form
    {
        public loginFRM()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)

        {

            RegistroFRM FRM = new RegistroFRM();
            FRM.Show();
            this.Hide();

        }

        string strConexao = MDI.strConexao;

        public void TestarConexao()
        {


            var conexao = new MySqlConnection(strConexao);

            try
            {

                conexao.Open();


            }
            catch (Exception ex)
            {

                MessageBox.Show("erro:" + ex);
                Application.Exit();

            }
            finally
            {

                conexao.Close();

            }

        }

        private void loginFRM_Load(object sender, EventArgs e)

        {
             
            TestarConexao();

        }

        private void btoLogar_Click(object sender, EventArgs e)
        {

            string sql = "select * from usuario where " +
                "Nome_Usuario = '" + operadorTXT.Text + "' and " +
                "Senha_Usuario = '" + senhaTXT.Text + "' and " +
                "caixa = '" + caixaTXT.Text + "'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader;
            conexao.Open();


            try
            {

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    MDI.IdUsuario = reader[0].ToString();
                    MDI.NomeUsuario = reader[1].ToString();
                    MDI.caixa = reader[2].ToString();

                    MDI FRM = new MDI();
                    FRM.Show();
                    this.Hide();
                    
                }
                else
                {

                    MessageBox.Show("ERRO: caixa, usuario ou senha errados! ");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex);
                Application.Exit();

            }
            finally
            {
                conexao.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)

        {

            Application.Exit();

        }
    }
}
