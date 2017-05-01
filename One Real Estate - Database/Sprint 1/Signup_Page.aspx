<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup_Page.aspx.cs" Inherits="One_Real_Estate___Database.Sprint_1.Signup_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signup</title>
</head>
<body style="height: 465px">
    <form id="Signup_Form" runat="server">
        <div style="height: 422px">


<asp:TextBox ID="FirstN_TextBox" placeholder="First name" runat="server" Width="225px" MaxLength="20" onkeydown="textBox1_KeyPress()" AutoPostBack="True" ></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="FirstN_RequiredFieldValidator" runat="server" ControlToValidate="FirstN_TextBox" ErrorMessage="* First name is required." ForeColor="#FF0066" ToolTip="First name is required." Width="180px" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
            
            <br />
            <br />



            <asp:TextBox ID="SurN_TextBox" placeholder="Surname" runat="server" Width="225px" MaxLength="15"></asp:TextBox>



            <br />
            <br />
            <asp:TextBox ID="MobileN_TextBox" placeholder="Mobile Number" runat="server" Width="225px" TextMode="Phone" MaxLength="18"></asp:TextBox>



            <br />
            <br />
            <asp:TextBox ID="EmailA_TextBox" placeholder="Email Address" runat="server" Width="225px" TextMode="Email" MaxLength="40"></asp:TextBox>



            <asp:RequiredFieldValidator ID="EmailA_RequiredFieldValidator" runat="server" ControlToValidate="EmailA_TextBox" ErrorMessage="* Email address is required." ForeColor="#FF0066" ToolTip="Email address is required." Width="180px" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>



            <asp:RegularExpressionValidator ID="EmailA_Validator" runat="server" ControlToValidate="EmailA_TextBox" ErrorMessage="* Invalid email address." ForeColor="#FF0066" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ToolTip="Please enter a valid emal address." Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator>



            <br />
            <br />
            <asp:TextBox ID="Password_TextBox" placeholder="Password" runat="server" Width="225px" TextMode="Password" MaxLength="64"></asp:TextBox>



            <asp:RequiredFieldValidator ID="Password_RequiredFieldValidator" runat="server" ControlToValidate="Password_TextBox" ErrorMessage="* Password is required." ForeColor="#FF0066" ToolTip="Password is required." Width="180px" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>



            <br />
            <br />
            <asp:TextBox ID="ConfirmP_TextBox" placeholder="Confirm password" runat="server" Width="225px" TextMode="Password" MaxLength="64"></asp:TextBox>



            <asp:RequiredFieldValidator ID="ConfirmP_RequiredFieldValidator" runat="server" ControlToValidate="ConfirmP_TextBox" ErrorMessage="* Please confirm pasword." ForeColor="#FF0066" ToolTip="Confirm password is required." Width="180px" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>



            <asp:CompareValidator ID="ConfirmP_Validator" runat="server" ControlToCompare="Password_TextBox" ControlToValidate="ConfirmP_TextBox" ErrorMessage="* Password does not match." ForeColor="#FF0066" ToolTip="Please match passwords." Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>



            <br />
            <br />
            Terms and Conditions<br />
            <br />
            <asp:Button ID="Signup_Button" runat="server" Text="Create Account" Width="132px" OnClick="Signup_Button_Click" />



        </div>
    </form>
</body>
</html>
