using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControl_C6_
{
    public partial class WebUserControl_Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
    }
}
