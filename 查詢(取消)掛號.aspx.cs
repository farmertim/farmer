using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 查詢_取消_掛號 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] str = new string[6];
            int j = 1;
            if (Request.Cookies[Convert.ToString(Session["account"])] != null)
            {
                for (int i = 1; i <= Convert.ToInt32(Request.Cookies[Convert.ToString(Session["account"])]["count"]); i++)
                {

                    if (Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))] != null)
                    {
                        
                        str[0] += Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))]["name"]) + "</br>";
                        str[1] += Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))]["femal"]) + "</br>";
                        str[2] += Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))]["phone"]) + "</br>";
                        str[3] += Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))]["time"]) + "</br>";
                        str[4] += Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))]["object"]) + "</br>";
                        str[5] += Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + Convert.ToString(i))]["doctor"]) + "</br>";

                        Panel1.Visible = true;
                        j++;
                    }

                }
            }
            else {
                Label7.Text = "資料填寫不完全，請重新填寫";
            }
            if (j != 1) {
                Label1.Text = str[0];
                Label2.Text = str[1];
                Label3.Text = str[2];
                Label4.Text = str[3];
                Label5.Text = str[4];
                Label6.Text = str[5];
            }
            if (j == 1)
            {

                Label7.Text = "資料填寫不完全，請重新填寫";
                Panel1.Visible = false;
            }
        }
    }




    protected void Button1_Click1(object sender, EventArgs e)
    {
        Server.Transfer("登陸頁面.aspx");
    }
}