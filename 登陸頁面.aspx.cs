using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 登陸頁面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = 1;
        int j = 0;
        string[] str = { "107316126", "107316154", "107316147", "107316122", "1" };
        string[] str1 = { "107316126", "107316154", "107316147", "107316122", "1" };
        for (int i = 0; i < 5; i++)
        {
            if (str[i] == TextBox1.Text)
            {
                if (str1[i] == TextBox2.Text)
                {
                    j = 1;
                    Session.Add("time", DateTime.Now.ToString());
                  
                        Session.Add("account", TextBox1.Text);

                        if (Request.Cookies[Convert.ToString(Session["account"])] == null)
                        {
                            Response.Cookies[Convert.ToString(Session["account"])]["account"] = TextBox1.Text;
                            Response.Cookies[Convert.ToString(Session["account"])]["count"] = Convert.ToString(count);


                        }
                        else
                        {
                            count += Convert.ToInt32(Request.Cookies[Convert.ToString(Session["account"])]["count"]);
                            Response.Cookies[Convert.ToString(Session["account"])]["count"] = Convert.ToString(count);


                        }
                  
                    Server.Transfer("初始頁面.aspx");
                }
            }
        }


        if (j == 0)
        {
            Response.Write("<script>alert('帳號密碼錯誤')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        int j = 0;
        string[] str = { "107316126", "107316154", "107316147", "107316122", "1" };
        string[] str1 = { "107316126", "107316154", "107316147", "107316122", "1" };
        for (int i = 0; i < 5; i++)
        {
            if (str[i] == TextBox1.Text)
            {
                if (str1[i] == TextBox2.Text)
                {
                    Session.Add("account", TextBox1.Text);
                    j = 1;
                    Server.Transfer("查詢(取消)掛號.aspx");
                }
            }
        }


        if (j == 0)
        {
            Response.Write("<script>alert('帳號密碼錯誤')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
      
    }
}