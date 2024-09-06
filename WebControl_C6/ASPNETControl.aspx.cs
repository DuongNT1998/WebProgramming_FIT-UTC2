using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebControl_C6_
{
    public partial class ASPNETControl : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e) //hàm PageLoad này được gọi khi user refresh lại trang web
        {
            var ctl = Page.LoadControl("WebUserControl_Login.ascx");
            PlaceHolderUserControl.Controls.Add(ctl);

            if (!Page.IsPostBack)//lệnh này kiểm tra xem trang web có đang postback (khi thực hiện TextChange trên txtString1) lại không
            //có thể thêm Item bằng mã lệnh thay vì thêm trên giao diện EditItem
            cmbChuyenNganh.Items.Insert(0, "");
            cmbChuyenNganh.Items.Add("Mạng truyền thông máy tính");
            Page.SetFocus(txtMatKhau);
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            txtString1.Text = cmbChuyenNganh.SelectedValue;
        }

         protected void btnCopy_Click(object sender, EventArgs e)
         {
             txtString2.Text= txtString1.Text;
         }
         /*hoặc có thể dùng thuộc tính TextChanged của Textbox mà không dùng button => phải bật AutoPostback = true
         protected void txtString1_TextChanged(object sender, EventArgs e)
         {
             txtString2.Text = txtString1.Text;
         }
        */





    }
}