using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 填基本資料 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            ImageButton1.Enabled = false;
            Label1.Visible = false;
            TextBox4.Enabled = false;
            DropDownList2.Enabled = false;

            if (PreviousPage != null)
            {
                Label label = (Label)Page.PreviousPage.FindControl("Label10");
                Label1.Text = label.Text;
            }
          

        }
    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        switch (DropDownList1.SelectedValue)
        {
            case "0":
                DropDownList2.Items.Add(new ListItem("--choice--", "0"));
                TextBox4.Enabled = false;
                ImageButton1.Enabled = false;
                break;
            case "台中市":
                DropDownList2.Items.Add(new ListItem("東區", "東區"));
                DropDownList2.Items.Add(new ListItem("北區", "北區"));
                DropDownList2.Items.Add(new ListItem("西區", "西區"));
                TextBox4.Enabled = true;
                ImageButton1.Enabled = true;
                DropDownList2.Enabled = true;
                break;
            case "台北市":
                DropDownList2.Items.Add(new ListItem("士林區", "士林區"));
                DropDownList2.Items.Add(new ListItem("信義區", "信義區"));
                TextBox4.Enabled = true;
                ImageButton1.Enabled = true;
                DropDownList2.Enabled = true;
                break;
            case "花蓮縣":
                DropDownList2.Items.Add(new ListItem("吉安鄉", "吉安鄉"));
                DropDownList2.Items.Add(new ListItem("秀林鄉", "秀林鄉"));
                TextBox4.Enabled = true;
                ImageButton1.Enabled = true;
                DropDownList2.Enabled = true;
                break;
            case "高雄市":
                DropDownList2.Items.Add(new ListItem("左營區", "左營區"));
                DropDownList2.Items.Add(new ListItem("三民區", "三民區"));
                TextBox4.Enabled = true;
                ImageButton1.Enabled = true;
                DropDownList2.Enabled = true;
                break;
        }
      
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e) {
        string[] str = (TextBox1.Text).Split(' ');
        string str1 = TextBox2.Text;
        if (str.Length != 3)
        {
            Response.Write("<script>alert('姓名:長度錯誤')</script>");
        }
       if (RadioButtonList1.SelectedValue != "男" && RadioButtonList1.SelectedValue != "女")
        {
            Response.Write("<script>alert('性別:點選性別')</script>");
        }
        if (str1.Length != 10)
        {
            Response.Write("<script>alert('電話:長度錯誤或不是數字')</script>");
        }
        else
        {
            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["name"] = Server.UrlEncode(TextBox1.Text);

            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["femal"] = Server.UrlEncode(RadioButtonList1.SelectedValue);

            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["phone"] = Server.UrlEncode(TextBox2.Text);

            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["id"] = Server.UrlEncode(TextBox3.Text);

            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["address"] = Server.UrlEncode(DropDownList1.SelectedValue + DropDownList2.SelectedValue + TextBox4.Text);


            Server.Transfer("顯示預約內容.aspx");
        }
    }
}