<%@ Page Language="C#" AutoEventWireup="true" CodeFile="填基本資料.aspx.cs" Inherits="填基本資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Main {
            margin-top:100px;
            width: 500px;
            height: 400px;
            text-align: center;
            background-color:gold;
            margin-left: auto;
            margin-right: auto;
            overflow:hidden;
        }

        table {
            margin-left: auto;
            margin-right: auto;
        }
        td {
            text-align:left;
        }
      .Button1{
          margin-left:0;
          padding:10px;
          width:75px;
      }
      .Button1:hover{
          color:tomato;
          font-weight:bold;
      }
      
        .auto-style1 {
            height: 31px;
        }
        .auto-style2 {
            width: 104%;
        }
      
    </style>
</head> 
<body>
    <form id="form1" runat="server">
        <div id="Main">
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <span style="border-bottom:solid; font-weight:bold;">填入基本資料:</span><br />
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style1">&nbsp;姓 名:</td>
                        <td class="auto-style1"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox1" ErrorMessage="請填寫姓名" EnableClientScript="False"></asp:RequiredFieldValidator></td>

                    </tr>
                    <tr>
                        <td>&nbsp;性 別:</td>
                        <td>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="請選擇性別" EnableClientScript="False"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;電 話:</td>
                        <td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox2" ErrorMessage="請填寫電話" EnableClientScript="False"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="填寫數字" ValidationExpression="^[0-9]*$" EnableClientScript="False"></asp:RegularExpressionValidator>
                        </td>

                    </tr>
                    <tr>
                        <td>身分證:</td>
                        <td>
                            &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox3" ErrorMessage="請填寫身分證" EnableClientScript="False"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <td>&nbsp;地 址:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem Value="0">--choice--</asp:ListItem>
                                <asp:ListItem>台中市</asp:ListItem>
                                <asp:ListItem>花蓮縣</asp:ListItem>
                                <asp:ListItem>台北市</asp:ListItem>
                                <asp:ListItem>高雄市</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox4" ErrorMessage="填寫地址" EnableClientScript="False"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                </table>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <div align="left">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageUrl="~/Images/123456.jpg" OnClick="ImageButton1_Click" Width="63px" BorderColor="#99FF33"  />
                    </div>

            </asp:Panel>
            <br />
            <br />

        </div>
    </form>
</body>
</html>
