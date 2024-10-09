using System.Windows.Forms;

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
    }
}
