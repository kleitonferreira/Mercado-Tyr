﻿using System;
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
                CBOproduto.Visible = false;
                quantidadeTXT.Visible = false;
                button1.Visible = false;
               

            }
            else
            {

                TextoCaixa.Text = "Caixa Aberto";
                panelCOR.BackColor = Color.Green;

            }

            qtdeLBL.Visible = false;
            precoLBL.Visible = false;
            totalQtdeLBL.Visible = false;
            ultimoProdutoLBL.Visible = false;
            TotalCompraLBL.Visible = false;
            PagamentoLBL.Visible = false;
            TrocoLBL.Visible = false;
            panel4.Visible = false;
           
            

      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void carregarComboProdutos() 
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


                CBOIDproduto.DisplayMember = "ID_Produto";
                CBOIDproduto.ValueMember = "ID_Produto";
                CBOIDproduto.DataSource = tabelaID;


                CBOproduto.DisplayMember = "Nome_Produto";
                CBOproduto.ValueMember = "ID_Produto";
                CBOproduto.DataSource = tabelaNome;


                //Quando o usuário seleciona um item em CBOprodutos, o evento SelectedIndexChanged é disparado.
                //O manipulador de evento então executa o código dentro das chaves { ... }.
                //O valor SelectedValue de CBOprodutos é atribuído a CBOid.SelectedValue, sincronizando ambas as ComboBox pelo ID_Produto

                CBOproduto.SelectedIndexChanged += (s, e) =>
                {

                    CBOIDproduto.SelectedValue = CBOproduto.SelectedValue;

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

        string strConexao = MDI.strConexao;

        private void button1_Click(object sender, EventArgs e)
        {

            if(novaCompra.venda == "")
            {

                MessageBox.Show("Nenhuma venda iniciada");

            }else
            {

                string quantidade = quantidadeTXT.Text;
                bool qtdeEhNumero = int.TryParse(quantidade, out int resultado);

                carregarComboProdutos();


                if (qtdeEhNumero == true)
                {

                    string sql = "insert into itens_venda " +
                    "(id_venda_item,id_produto_item,quantidade_produto_item)" +
                    "values" +
                    "('" + novaCompra.venda + "','" + CBOIDproduto.Text + "','" + quantidade + "')";

                    MySqlConnection conexao = new MySqlConnection(strConexao);
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.CommandType = CommandType.Text;
                    conexao.Open();

                    try
                    {

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {

                            CBOproduto.Text = "";
                            quantidadeTXT.Text = "";


                            string venda = "select * from venda" +
                                 "INNER JOIN itens_venda where venda.id_venda = '" + novaCompra.venda + "'";

                         


                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro:" + ex.ToString());

                    }
                    finally
                    {

                        conexao.Close();

                    }

                }
                else
                {

                    MessageBox.Show("Insira uma quantidade Valida!");

                }

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
                if (novaCompra.venda != "")
                    MessageBox.Show("venda ja iniciada");
                else
                    MessageBox.Show("Caixa fechado");
                
            }

        }
    }
}
