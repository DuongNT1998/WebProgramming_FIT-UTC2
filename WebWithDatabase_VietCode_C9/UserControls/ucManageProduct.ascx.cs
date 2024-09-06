using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLayout_C7_.UserControls
{
    public partial class ucManageProduct : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
                BindGridView();
                BindDropDownList();
        }

        protected void GridViewProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
        protected void BindGridView()
        {
            MyShopEntities2 context = new MyShopEntities2();
            var query = (from p in context.Products select p).ToList<Product>();
            GridViewProducts.DataSource = query;
            GridViewProducts.DataBind();
        }
       

        protected void GridViewProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            MyShopEntities2 context = new MyShopEntities2();
            var product = (from p in context.Products where p.id == id select p).SingleOrDefault();
            if (product != null)
                context.Products.Remove(product);
            context.SaveChanges();
            BindGridView();
        }
        protected void BindDropDownList()
        {
            MyShopEntities2 context = new MyShopEntities2();
            DropDownListCategory.DataSource = (from c in context.Categories select c).ToList<Category>();
            DropDownListCategory.DataTextField = "Name";
            DropDownListCategory.DataValueField = "id";
            DropDownListCategory.DataBind();



        }

        protected void ButtonAddNew_Click(object sender, EventArgs e)
        {
            string filename = "";
            if (FileUploadPicture.HasFile)
            {
                filename = FileUploadPicture.FileName;
                FileUploadPicture.SaveAs(Server.MapPath("~/images/Products/" + filename ));
            }
            MyShopEntities2 context = new MyShopEntities2();
            Product p = new Product();
            p.Name = TextBoxName.Text;
            p.Price = decimal.Parse(TextBoxPrice.Text);
            p.Category_id = int.Parse(DropDownListCategory.SelectedValue);
            p.Description= TextBoxDescription.Text;
            p.FilePath = filename;
            context.Products.Add(p);
            context.SaveChanges();
            BindGridView();


        }
    }
}