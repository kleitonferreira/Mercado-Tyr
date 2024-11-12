using MySql.Data.MySqlClient;
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
    public partial class RegistroFRM : Form
    {
        public RegistroFRM()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)

        {

            loginFRM FRM = new loginFRM();
            FRM.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)

        {

            Application.Exit();

        }

        string strConexao = MDI.strConexao;


        private void button1_Click(object sender, EventArgs e)


        {

            string sql = "insert into usuario" +
                "(nome_usuario,caixa,Senha_usuario)" +
                "values" +
                "('" + operadorTXT.Text + "'," + CaixaTXT.Text + "," + senhaTXT.Text + ")";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;
            conexao.Open();


            string chave = chaveTXT.Text;
            if (chave != "AAAA")
            {

                MessageBox.Show("Chave Invalida");
                Application.Restart();

            }
            else
            {

                try
                {

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Registro realizado com sucesso!, faça login para continuar!");
                        loginFRM FRM = new loginFRM();
                        FRM.Show();
                        this.Close();

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

        }

        private void RegistroFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
