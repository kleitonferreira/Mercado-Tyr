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

            // string sql = "select"
        
        
        }
    }
}
