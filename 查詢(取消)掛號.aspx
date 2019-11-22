<%@ Page Language="C#" AutoEventWireup="true" CodeFile="查詢(取消)掛號.aspx.cs" Inherits="查詢_取消_掛號" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
        text-align:center;
        }
    </style>
    <style type="text/css">

        .auto-style23 {
            height: 63px;
            width: 130px;
        }
        .auto-style24 {
            height: 63px;
            width: 212px;
        }
        .auto-style25 {
            width: 255px;
            height: 63px;
        }
        .auto-style28 {
            height: 63px;
        }
        .auto-style29 {
            height: 39px;
            width: 130px;
        }
        .auto-style30 {
            height: 39px;
            width: 212px;
        }
        .auto-style31 {
            width: 255px;
            height: 39px;
        }
        .auto-style34 {
            height: 39px;
        }
        .auto-style35 {
            height: 39px;
            width: 273px;
        }
        .auto-style36 {
            height: 63px;
            width: 273px;
        }
        .auto-style37 {
            height: 39px;
            width: 267px;
        }
        .auto-style38 {
            height: 63px;
            width: 267px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            查詢掛號結果<br />
            <table style="border-style: solid; border-width: inherit; border-color: black; width:100%; border-collapse: collapse; table-layout: auto; border-spacing: 2px;">
                <tr>
                    <td class="auto-style29" style="border-style: solid; border-width: inherit; border-color: black">姓名</td>
                    <td class="auto-style30" style="border-style: solid; border-width: inherit; border-color: black">性別</td>
                    <td class="auto-style31" style="border-style: solid; border-color: black">電話</td>
                    <td class="auto-style37" style="border-style: solid; border-color: black">時間日期</td>
                    <td class="auto-style35" style="border-style: solid; border-color:black">科別</td>
                    <td class="auto-style34" style="border-style: solid; border-color:black">醫生</td>
                </tr>
                <tr>
                    <td class="auto-style23" style="border-style: solid; border-width: inherit; border-color: black">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style24" style="border-style: solid; border-width: inherit; border-color:black">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style25" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style38" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style36" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style28" style="border-style: solid; border-color:black">
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" style="height: 27px" Text="回主畫面" />
        <br />
    
    </div>
    </form>
</body>
</html>
