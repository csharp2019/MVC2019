<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PozdravnaPoruka.aspx.cs" Inherits="WebFormsPrimjer.PozdravnaPoruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ovo je pozdravna poruka <br />
            <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label><br />
            <asp:TextBox ID="txtIme" runat="server" ForeColor="#FFFF99"></asp:TextBox><br />
            <asp:Button ID="btnObradi" runat="server" Text="Button" BackColor="#003300" Font-Bold="True" ForeColor="#CCCCFF" Height="51px" OnClick="btnObradi_Click" Width="127px" /><br />
            <br />
            <asp:Label ID="lblRezultat" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
