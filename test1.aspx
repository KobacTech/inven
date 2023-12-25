<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="test1.aspx.vb" Inherits="Inven.test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Select User</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Users</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
