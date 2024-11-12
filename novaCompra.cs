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
    public partial class novaCompra : Form
    {

        public novaCompra()
        {
            InitializeComponent();
           
      
        }

        
       
        private void novaCompra_Load(object sender, EventArgs e)

        {

            

            

            if (MDI.statusCaixa == "fechado")
            {

                TextoCaixa.Text = "Caixa Fechado";
                panelCOR.BackColor = Color.Red;
            

            }else {

                TextoCaixa.Text = "Caixa Aberto";
                panelCOR.BackColor = Color.Green;

            }
          

        }

        
    }
}
