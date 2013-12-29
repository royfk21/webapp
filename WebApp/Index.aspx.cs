using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppLibrary;

namespace WebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            App appName = new App() {Name = "Roy"};
            lblName.Text = "Hello " + appName.Name;
        }
    }
}