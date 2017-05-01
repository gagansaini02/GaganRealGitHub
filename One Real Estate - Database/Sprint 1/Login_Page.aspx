<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="One_Real_Estate___Database.Sprint_1.Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body style="height: 472px">
    <form id="Login_Form" runat="server">
        <div style="height: 435px">




            <asp:TextBox ID="UserN_TextBox" placeholder="User name" runat="server" Width="225px" TextMode="Email"></asp:TextBox>




            <asp:RequiredFieldValidator ID="UserN_RequiredFieldValidator" runat="server" ControlToValidate="UserN_TextBox" Display="Dynamic" ErrorMessage="* User name is required." ForeColor="#FF0066" SetFocusOnError="True" ToolTip="Please enter registered email address." Width="200px"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="UserN_RegularExpressionValidator" runat="server" ControlToValidate="UserN_TextBox" Display="Dynamic" ErrorMessage="* Invalid user name." ForeColor="#FF0066" SetFocusOnError="True" ToolTip="Please enter a valid emal address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>




            <br />
            <br />
            <asp:TextBox ID="Password_TextBox" placeholder="Password" runat="server" Height="16px" Width="225px" TextMode="Password"></asp:TextBox>




            <asp:RequiredFieldValidator ID="Password_RequiredFieldValidator" runat="server" ControlToValidate="Password_TextBox" Display="Dynamic" ErrorMessage="* Password is required." ForeColor="#FF0066" SetFocusOnError="True" ToolTip="Please enter a valid password." Width="200px"></asp:RequiredFieldValidator>




            <br />
            <br />
            <asp:Button ID="Login_Button" runat="server" Text="Login" Width="97px" OnClick="Login_Button_Click" />




        </div>
    </form>
</body>
</html>
