using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 顯示預約內容 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string s;
        if (!IsPostBack)
        {
            string[] person;
            string str;

            if (Convert.ToInt32(Request.Cookies[Convert.ToString(Session["account"])]["count"]) == 1)
            {

                TextBox name = (TextBox)Page.PreviousPage.FindControl("TextBox1");
                RadioButtonList femal = (RadioButtonList)Page.PreviousPage.FindControl("RadioButtonList1");
                TextBox phone = (TextBox)Page.PreviousPage.FindControl("TextBox2");
                TextBox id = (TextBox)Page.PreviousPage.FindControl("TextBox3");
                DropDownList address1 = (DropDownList)Page.PreviousPage.FindControl("DropDownList1");
                DropDownList address2 = (DropDownList)Page.PreviousPage.FindControl("DropDownList2");
                TextBox address = (TextBox)Page.PreviousPage.FindControl("TextBox4");
                Label b = (Label)Page.PreviousPage.FindControl("Label1");
                str = b.Text;
                person = str.Split('.');
                this.doctor1.Text = person[3];
                this.object1.Text = person[0];
                this.day1.Text = person[2];
                this.time1.Text = person[1];

                this.name1.Text = name.Text;
                this.femal1.Text = femal.Text;
                this.phone1.Text = phone.Text;
                this.id1.Text = id.Text;
                this.address1.Text = address1.Text + address2.SelectedValue + address.Text;
                s = Server.UrlEncode(name1.Text);
                Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["name"] = s;
                s = Server.UrlEncode(femal1.Text);
                Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["femal"] = s;
                s = Server.UrlEncode(phone1.Text);
                Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["phone"] = s;
                s = Server.UrlEncode(id1.Text);
                Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["id"] = s;
                s = Server.UrlEncode(address1.Text);
                Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["address"] = s;

            }
           
               else if (Convert.ToInt32(Request.Cookies[Convert.ToString(Session["account"])]["count"]) > 1)
                {
                    this.name1.Text = Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + "1")]["name"]);
                    this.femal1.Text = Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + "1")]["femal"]);
                    this.phone1.Text = Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + "1")]["phone"]);
                    this.id1.Text = Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account"] + "1")]["id"]);
                    this.address1.Text = Server.UrlDecode(Request.Cookies[Convert.ToString(Session["account_" + "1"])]["address"]);
                    Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["name"] = Server.UrlEncode(name1.Text);
                    Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["femal"] = Server.UrlEncode(femal1.Text);
                    Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["phone"] = Server.UrlEncode(phone1.Text);
                    Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["id"] = Server.UrlEncode(id1.Text);
                    Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["address"] = Server.UrlEncode(address1.Text);
                    Label b1 = (Label)Page.PreviousPage.FindControl("Label10");
                    str = b1.Text;
                    person = str.Split('.');


                    this.doctor1.Text = person[3];
                    this.object1.Text = person[0];
                    this.day1.Text = person[2];
                    this.time1.Text = person[1];
                }
            

            s = Server.UrlEncode(day1.Text + time1.Text);
            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["time"] = s;
            s = Server.UrlEncode(object1.Text);
            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["object"] = s;
            s = Server.UrlEncode(doctor1.Text);
            Response.Cookies[Convert.ToString(Session["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"])]["doctor"] = s;


        }
    }



    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Write("<script>alert('thank bye')</script>");
        Server.Transfer("登陸頁面.aspx");
    }
}