<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Adm_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Login:" runat="server" /> <br />
        <asp:TextBox runat="server" ID="txtLogin"  /> <br />
        <asp:Label Text="Senha:" runat="server" /> <br />
        <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" /> <br />

        <asp:Button id="btnLogin" Text="Entrar" runat="server" OnClick="btnLogin_Click" />
    </div>
    </form>
</body>
</html>
