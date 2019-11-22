<%@ Page Language="C#" AutoEventWireup="true" CodeFile="預約.aspx.cs" Inherits="預約" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div {
        background-color:antiquewhite;
        }
        .auto-style23 {
            height: 63px;
            width: 130px;
        }
        .auto-style24 {
            height: 63px;
            width: 212px;
        }
        .auto-style25 {
            width: 205px;
            height: 63px;
        }
        .auto-style26 {
            width: 208px;
            height: 63px;
        }
        .auto-style27 {
            height: 63px;
            width: 173px;
        }
        .auto-style28 {
            height: 63px;
        }
        .auto-style29 {
            height: 66px;
            width: 130px;
        }
        .auto-style30 {
            height: 66px;
            width: 212px;
        }
        .auto-style31 {
            width: 205px;
            height: 66px;
        }
        .auto-style32 {
            width: 208px;
            height: 66px;
        }
        .auto-style33 {
            height: 66px;
            width: 173px;
        }
        .auto-style34 {
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="label" runat="server"></asp:Label>
            <br />
            選擇日期範圍:<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="0">108/11/18~108/11/22</asp:ListItem>
                <asp:ListItem Value="1">108/11/25~108/11/29</asp:ListItem>
            </asp:DropDownList>
            &nbsp;時段:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="0">上午</asp:ListItem>
                <asp:ListItem Value="1">下午</asp:ListItem>
            </asp:DropDownList>
            <br />
            <table style="border-style: solid; border-width: inherit; border-color: black; width:100%; border-collapse: collapse; table-layout: auto; border-spacing: 2px;">
                <tr>
                    <td class="auto-style29" style="border-style: solid; border-width: inherit; border-color: black"></td>
                    <td class="auto-style30" style="border-style: solid; border-width: inherit; border-color: black">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style31" style="border-style: solid; border-color: black">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style32" style="border-style: solid; border-color: black">
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style33" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style34" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23" style="border-style: solid; border-width: inherit; border-color: black">
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style24" style="border-style: solid; border-width: inherit; border-color:black">無門診</td>
                    <td class="auto-style25" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label9" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style26" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style27" style="border-style: solid; border-color:black">助教</td>
                    <td class="auto-style28" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label8" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            請選擇:<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" RepeatLayout="Flow" AutoPostBack="True">
                <asp:ListItem Value="1">星期二</asp:ListItem>
                <asp:ListItem Value="2">星期三</asp:ListItem>
                <asp:ListItem Value="3">星期四</asp:ListItem>
                <asp:ListItem Value="4">星期五</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="草稿" Height="38px" Width="61px" />
            <asp:Label ID="Label10" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
    
    
    </div>
    </form>
</body>
</html>
