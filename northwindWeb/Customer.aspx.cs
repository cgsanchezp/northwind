using northwindWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace northwindWeb
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerModel oCustomerModel = new CustomerModel();
            dgvcustomer.DataSource = oCustomerModel.FillGrtidView();
            dgvcustomer.DataBind();


        }
    }
}