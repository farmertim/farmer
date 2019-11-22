<%@ Page Language="C#" AutoEventWireup="true" CodeFile="登陸頁面.aspx.cs" Inherits="登陸頁面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
         width:200px;
         margin-left:auto;
         margin-right:auto;
           text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 50px; background-color: #FFCC99;">
    
        <span style="color: rgb(0, 102, 153); font-family: &quot;Noto Sans TC&quot;, Arial, &quot;Microsoft JhengHei&quot;, &quot;Droid Sans&quot;, Helvetica, &quot;Heiti TC&quot;, sans-serif; font-size: 21px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 600; letter-spacing: normal; orphans: 2; text-align: -webkit-center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none; background-color: #FFCC66;">&nbsp;網 路 掛 號</span><br />
    
        帳號:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        密碼:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="掛號" />
    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="查詢掛號" />
    
    </div>
    </form>
</body>
</html>
