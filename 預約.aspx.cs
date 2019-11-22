using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 預約 : System.Web.UI.Page
{

    static int c = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
         
            Button1.Enabled = false;
            if (PreviousPage != null)
            {
                DropDownList b = (DropDownList)Page.PreviousPage.FindControl("DropDownList1");

                switch (b.SelectedValue)
                {
                    case "0":
                        c = 1;
                        break;
                    case "1":
                        c = 2;
                        break;
                    case "2":
                        c = 3;
                        break;
                }
                page();
            }
        }
    }
    public void page()
    {
        if (c == 1)
        {
            label.Text = ("牙科");
            switch (DropDownList2.SelectedValue)
            {
                case "0":
                    Label6.Text = "上午";
                    switch (DropDownList1.SelectedValue)
                    {
                        case "0":
                            Label1.Text = ("11/18(一)");
                            Label2.Text = ("11/19(二)");
                            Label3.Text = ("11/20(三)");
                            Label4.Text = ("11/21(四)");
                            Label5.Text = ("11/22(五)");
                            Label7.Text = "楊子億";
                            Label8.Text = "胡維仁";
                            Label9.Text = "蔡曜安";
                            break;
                        case "1":
                            Label1.Text = ("11/25(一)");
                            Label2.Text = ("11/26(二)");
                            Label3.Text = ("11/27(三)");
                            Label4.Text = ("11/28(四)");
                            Label5.Text = ("11/29(五)");
                            Label8.Text = "陳盈竹";
                            Label7.Text = "楊子億";
                            Label9.Text = "胡維仁";
                            break;
                    }
                    break;
                case "1":
                    Label6.Text = "下午";
                    switch (DropDownList1.SelectedValue)
                    {
                        case "0":
                            Label1.Text = ("11/18(一)");
                            Label2.Text = ("11/19(二)");
                            Label3.Text = ("11/20(三)");
                            Label4.Text = ("11/21(四)");
                            Label5.Text = ("11/22(五)");
                            Label7.Text = "陳盈竹";
                            Label9.Text = "楊子億";
                            Label8.Text = "胡維仁";
                            break;
                        case "1":
                            Label1.Text = ("11/25(一)");
                            Label2.Text = ("11/26(二)");
                            Label3.Text = ("11/27(三)");
                            Label4.Text = ("11/28(四)");
                            Label5.Text = ("11/29(五)");
                            Label8.Text = "陳盈竹";
                            Label9.Text = "楊子億";
                            Label7.Text = "胡維仁";

                            break;
                    }
                    break;
            }
        }
        if (c == 2)
        {
            label.Text = ("眼科");
            switch (DropDownList2.SelectedValue)
            {
                case "0":
                    Label6.Text = "上午";
                    switch (DropDownList1.SelectedValue)
                    {
                        case "0":
                            Label1.Text = ("11/18(一)");
                            Label2.Text = ("11/19(二)");
                            Label3.Text = ("11/20(三)");
                            Label4.Text = ("11/21(四)");
                            Label5.Text = ("11/22(五)");
                            Label8.Text = ("鄭伊伶");
                            Label7.Text = ("江辰霈");
                            Label9.Text = ("Kevin");
                            break;
                        case "1":
                            Label1.Text = ("11/25(一)");
                            Label2.Text = ("11/26(二)");
                            Label3.Text = ("11/27(三)");
                            Label4.Text = ("11/28(四)");
                            Label5.Text = ("11/29(五)");
                            Label7.Text = ("鄭伊伶");
                            Label8.Text = ("江辰霈");
                            Label9.Text = ("Kevin");
                            break;
                    }
                    break;
                case "1":
                    Label6.Text = "下午";
                    switch (DropDownList1.SelectedValue)
                    {
                        case "0":
                            Label1.Text = ("11/18(一)");
                            Label2.Text = ("11/19(二)");
                            Label3.Text = ("11/20(三)");
                            Label4.Text = ("11/21(四)");
                            Label5.Text = ("11/22(五)");
                            Label8.Text = ("鄭伊伶");
                            Label9.Text = ("江辰霈");
                            Label7.Text = ("Kevin");
                            break;
                        case "1":
                            Label1.Text = ("11/25(一)");
                            Label2.Text = ("11/26(二)");
                            Label3.Text = ("11/27(三)");
                            Label4.Text = ("11/28(四)");
                            Label5.Text = ("11/29(五)");
                            Label9.Text = ("鄭伊伶");
                            Label8.Text = ("江辰霈");
                            Label7.Text = ("Kevin");
                            break;
                    }
                    break;
            }
        }
        if (c == 3)
        {
            label.Text = ("骨科");
            switch (DropDownList2.SelectedValue)
            {
                case "0":
                    Label6.Text = "上午";
                    switch (DropDownList1.SelectedValue)
                    {
                        case "0":
                            Label1.Text = ("11/18(一)");
                            Label2.Text = ("11/19(二)");
                            Label3.Text = ("11/20(三)");
                            Label4.Text = ("11/21(四)");
                            Label5.Text = ("11/22(五)");
                            Label7.Text = ("吳玟嫻");
                            Label9.Text = ("藍兄弟");
                            Label8.Text = ("吃貨妹");
                            break;
                        case "1":
                            Label1.Text = ("11/25(一)");
                            Label2.Text = ("11/26(二)");
                            Label3.Text = ("11/27(三)");
                            Label4.Text = ("11/28(四)");
                            Label5.Text = ("11/29(五)");
                            Label9.Text = ("吳玟嫻");
                            Label7.Text = ("藍兄弟");
                            Label8.Text = ("吃貨妹");
                            break;
                    }
                    break;
                case "1":
                    Label6.Text = "下午";
                    switch (DropDownList1.SelectedValue)
                    {
                        case "0":
                            Label1.Text = ("11/18(一)");
                            Label2.Text = ("11/19(二)");
                            Label3.Text = ("11/20(三)");
                            Label4.Text = ("11/21(四)");
                            Label5.Text = ("11/22(五)");
                            Label8.Text = ("吳玟嫻");
                            Label9.Text = ("藍兄弟");
                            Label7.Text = ("吃貨妹");
                            break;
                        case "1":
                            Label1.Text = ("11/25(一)");
                            Label2.Text = ("11/26(二)");
                            Label3.Text = ("11/27(三)");
                            Label4.Text = ("11/28(四)");
                            Label5.Text = ("11/29(五)");
                            Label7.Text = ("吳玟嫻");
                            Label8.Text = ("藍兄弟");
                            Label9.Text = ("吃貨妹");
                            break;
                    }
                    break;
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        page();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

        page();
    }
    static int count = 0;
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Button1.Enabled = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        switch (RadioButtonList1.SelectedValue)
        {
            case "1":
                Label10.Text = label.Text + "." + Label2.Text + "." + Label6.Text + "." + Label9.Text;
                break;
            case "2":
                Label10.Text = label.Text + "." + Label3.Text + "." + Label6.Text + "." + Label7.Text;
                break;
            case "3":
                Label10.Text = label.Text + "." + Label4.Text + "." + Label6.Text + "." + "助教";
                break;
            case "4":
                Label10.Text = label.Text + "." + Label5.Text + "." + Label6.Text + "." + Label8.Text;
                break;
        }
        if (Convert.ToInt32(Request.Cookies[Convert.ToString(Session["account"])]["count"]) == 1)
        {
            Session.Add("account_" + Request.Cookies[Convert.ToString(Session["account"])]["count"], Request.Cookies[Convert.ToString(Session["account"])]["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"]);
         
            Server.Transfer("填基本資料.aspx");
        }
        else {
            Session.Add("account_" + Request.Cookies[Convert.ToString(Session["account"])]["count"], Request.Cookies[Convert.ToString(Session["account"])]["account"] + Request.Cookies[Convert.ToString(Session["account"])]["count"]);
            Server.Transfer("顯示預約內容.aspx");
        }

       

    }
}