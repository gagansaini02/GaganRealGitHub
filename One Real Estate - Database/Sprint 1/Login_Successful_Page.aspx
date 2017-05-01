<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Successful_Page.aspx.cs" Inherits="One_Real_Estate___Database.Sprint_1.Login_Successful_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Successful</title>
</head>
<body style="height: 489px">
    <form id="Login_Successful_Form" runat="server">
        <div style="height: 434px">
            <asp:Label ID="Welcome_Label" runat="server" Width="150px" style="margin-left: 0px"  ></asp:Label>
            <asp:Button ID="Logout_Button" runat="server" Text="Logout"  style="margin-left: 1200px" OnClick="Logout_Button_Click"/>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Welcome...!!!</div>
    </form>
</body>
</html>
