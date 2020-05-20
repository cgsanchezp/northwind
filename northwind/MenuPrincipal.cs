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
    public partial class MenuPrincipal : Form
    {
        private string myform;

        public MenuPrincipal()
        {
            InitializeComponent();
        }     

        private void optCustomer_Click(object sender, EventArgs e)
        {
            myform = "cus";
            
            FrmCustomer oFrmCustomer = new FrmCustomer();
            oFrmCustomer.MdiParent = this;
            oFrmCustomer.Show();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            if(myform == "cus")
            {
                MessageBox.Show("formulario customer");
            }
        }
    }
}
