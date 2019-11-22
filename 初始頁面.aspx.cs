using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 初始頁面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            Button2.Enabled = false;

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
      
        Server.Transfer("預約.aspx",true);
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedValue)
        {
            case "0":
                Button2.Enabled = true;
                break;
            case "1":
                Button2.Enabled = true;
                break;
            case "2":
                Button2.Enabled = true;
                break;
            default:
                Button2.Enabled = false;
                break;
        }
    }

    

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Server.Transfer("登陸頁面.aspx");
    }
}