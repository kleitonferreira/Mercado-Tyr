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
    public partial class MDI : Form
    {

        public static string strConexao = "server=localhost;uid=root;database = mercado";
        public static string NomeUsuario;
        public static string caixa;
        public static string statusCaixa;
        public static string tela;


        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)

        {



            dataLBL.Text = DateTime.Now.ToString("dd/MM/yyyy          HH:mm");
            telaLBL.Visible = false;
            panelDIV.Visible = false;


            UsuarioLBL.Text = MDI.NomeUsuario;
            caixaLBL.Text = "Caixa: " + MDI.caixa;
            MDI.statusCaixa = "fechado";

        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)

        {

            if (activeForm == null)
            {

                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }
            else
            {

                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }

        }

        public void ClicarBotao1()
        {
            button1.PerformClick(); 
        }
        public void ClicarBotao2()
        {
            button2.PerformClick();
        }
        public void ClicarBotao3()
        {
            button3.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            openChildForm(new novaCompra());
            telaLBL.Text = "Nova Compra";
            MDI.tela = "Nova Compra";
            panelDIV.Visible = true;
            telaLBL.Visible = true;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            openChildForm(new estoque());
            telaLBL.Text = "Estoque";
            MDI.tela = "Estoque";
            panelDIV.Visible = true;
            telaLBL.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            openChildForm(new historico());
            telaLBL.Text = "Historico de vendas";
            MDI.tela = "Historico de vendas";
            panelDIV.Visible = true;
            telaLBL.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)

        {

            if (MDI.statusCaixa == "fechado")
            {

                abrirCaixa FRM = new abrirCaixa(this);
                FRM.ShowDialog();
            }
            else {

                MessageBox.Show("O caixa ja esta aberto!");
            
            }

        }
    }
}
