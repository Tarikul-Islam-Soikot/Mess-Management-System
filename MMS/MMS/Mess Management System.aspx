<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mess Management System.aspx.cs" Inherits="MMS.Mess_Management_System" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Deposit" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Extra" />
        <br />
        <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Bazar" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Meal" />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Transaction" />
        <br />
    
    </div>
    </form>
</body>
</html>
