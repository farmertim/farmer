<%@ Page Language="C#" AutoEventWireup="true" CodeFile="顯示預約內容.aspx.cs" Inherits="顯示預約內容" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Document</title>
    <style>
        div {
            text-align:center;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Panel ID="Panel1" runat="server" BackColor="#66FF33" BorderColor="Black" BorderStyle="Double" Font-Size="X-Large" ForeColor="#6600CC" Height="400px" Width="500px">
                預約成功!!!!<br /> 您的基本資料與掛號資料如下:<br /> 姓名:<asp:Label ID="name1" runat="server"></asp:Label>
                <br />
                性別:<asp:Label ID="femal1" runat="server"></asp:Label>
                <br />
                電話:<asp:Label ID="phone1" runat="server"></asp:Label>
                <br />
                身分證:<asp:Label ID="id1" runat="server"></asp:Label>
                <br />
                地址:<asp:Label ID="address1" runat="server"></asp:Label>
                <br />
                科別:<asp:Label ID="object1" runat="server"></asp:Label>
                <br />
                看診日期:<asp:Label ID="day1" runat="server"></asp:Label>
                <br />
                當日時段:<asp:Label ID="time1" runat="server"></asp:Label>
                <br />
                醫生:<asp:Label ID="doctor1" runat="server"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="回主畫面" />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
