<%@ Page Language="C#" AutoEventWireup="true" CodeFile="初始頁面.aspx.cs" Inherits="初始頁面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
         
            text-align:center;
            align-content:center;
            
            
        }
        .auto-style1 {
            height: 280px;
            width: 622px;
            margin-left: 308px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div class="auto-style1" style="padding: 50px; background-color: #99FF99; clip: rect(50px, auto, auto, auto)">
    
         <asp:Image ID="Image1" runat="server" Height="103px" Width="358px" ImageUrl="~/Images/123456.jpg" />
    
         <br />
    
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                <asp:ListItem Value="6">請查詢科別</asp:ListItem>
                <asp:ListItem Value="0">牙科</asp:ListItem>
                <asp:ListItem Value="1">眼科</asp:ListItem>
                <asp:ListItem Value="2">骨科</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  Text="確定" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="登出" />
            <br />
            <br />
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
