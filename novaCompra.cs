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
    public partial class novaCompra : Form
    {

        public static string venda = "";

        public novaCompra()
        {
            InitializeComponent();

        }



        public void novaCompra_Load(object sender, EventArgs e)

        {

            if (MDI.statusCaixa == "fechado")
            {

                TextoCaixa.Text = "Caixa Fechado";
                panelCOR.BackColor = Color.Red;


            }
            else
            {

                TextoCaixa.Text = "Caixa Aberto";
                panelCOR.BackColor = Color.Green;

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        string strConexao = MDI.strConexao;

        private void button1_Click(object sender, EventArgs e)
        {

            if (novaCompra.venda == "")
            {

                MessageBox.Show("Nenhuma venda iniciada, impossivel adicionar produto!");

            }
            else
            {

              
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(novaCompra.venda == "" && MDI.statusCaixa == "aberto")
            {

                string sql = "insert into venda" +
                    "(status_venda)" +
                    "values" +
                    "('Iniciada')";


                MySqlConnection conexao = new MySqlConnection(strConexao);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;
                conexao.Open();
                

                try
                {

                    int rowsAffected = cmd.ExecuteNonQuery();
                    //reader = cmd.ExecuteReader();
                   

                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Criou venda");
                        string id = "select LAST_INSERT_ID()";

                        MySqlConnection con = new MySqlConnection(strConexao);
                        MySqlCommand comand = new MySqlCommand(id, conexao);
                        cmd.CommandType = CommandType.Text;
                        MySqlDataReader reader;

                        try
                        {

                            reader = comand.ExecuteReader();
                            if (reader.Read())
                            {

                                novaCompra.venda = reader[0].ToString();
                                MessageBox.Show(novaCompra.venda);

                            }


                        }
                        catch (Exception ex)
                        {
    
                            MessageBox.Show("erro: " + ex.ToString);

                        }

                    }
                    else
                    {

                        MessageBox.Show("NADA");

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.ToString());


                }
                finally
                {

                    conexao.Close();

                }

            }else
            {

                MessageBox.Show("Caixa fechado");
                MessageBox.Show(novaCompra.venda);

            }

        }
    }
}
