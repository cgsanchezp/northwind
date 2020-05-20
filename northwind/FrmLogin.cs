using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace northwindDesktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

            Logic oLogic = new Logic();
            bool validate = oLogic.validateUser(user, pass);

            if(validate == true)
            {
                MenuPrincipal oMenuPrincipal = new MenuPrincipal();
                oMenuPrincipal.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario y contraseña no valido");
            }
            
        }
    }
}
