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
        public static string IdUsuario;
        public static string caixa;
        public static string statusCaixa;
        public static string tela;


        public MDI()
        {
            InitializeComponent();



        }

        private void MDI_Load(object sender, EventArgs e)

        {

            timer1.Interval = 1000; // Atualiza a cada 1 segundo
            timer1.Start(); // Inicia o Timer

            dataLBL.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

            openChildForm(new novaCompra(this));
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
            else
            {

                MessageBox.Show("O caixa ja esta aberto!");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            FecharCaixa FRM = new FecharCaixa(this);
            FRM.ShowDialog();

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            palito1.Visible = true;
            button1.Font = new Font(button1.Font, FontStyle.Underline);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            palito1.Visible = false;
            button1.Font = new Font(button1.Font, button1.Font.Style & ~FontStyle.Underline);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            palito2.Visible = true;
            button2.Font = new Font(button1.Font, FontStyle.Underline);

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            palito2.Visible = false;
            button2.Font = new Font(button1.Font, button1.Font.Style & ~FontStyle.Underline);

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            palito3.Visible = true;
            button3.Font = new Font(button1.Font, FontStyle.Underline);

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            palito3.Visible = false;
            button3.Font = new Font(button1.Font, button1.Font.Style & ~FontStyle.Underline);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

            palito4.Visible = true;
            button4.Font = new Font(button1.Font, FontStyle.Underline);


        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {

            palito4.Visible = false;
            button4.Font = new Font(button1.Font, button1.Font.Style & ~FontStyle.Underline);

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

            palito5.Visible = true;
            button5.Font = new Font(button1.Font, FontStyle.Underline);

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            palito5.Visible = false;
            button5.Font = new Font(button1.Font, button1.Font.Style & ~FontStyle.Underline);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToString("HH:mm");

        }
    }
}
