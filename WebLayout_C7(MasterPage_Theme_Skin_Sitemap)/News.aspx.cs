using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLayout_C7_
{
    public partial class News : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Image imgBanner = (Image)Master.FindControl("imgBanner");
            //imgBanner.ImageUrl = "~/images/banner_2.jpg";
        }

      
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.ButtonSearch.Click += ButtonSearch_Click;
        }
        void ButtonSearch_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Button Search Clicked";
        }



}
}