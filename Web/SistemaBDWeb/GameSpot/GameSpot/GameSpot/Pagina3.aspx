﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina3.aspx.cs" Inherits="GameSpot.Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Los datos del usuario son:<br />
        <br />
        Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Edad:&nbsp;&nbsp;
        <asp:TextBox ID="txEdad" runat="server"></asp:TextBox>
        <br />
        <br />
        Sexo:&nbsp;&nbsp;
        <asp:TextBox ID="txSexo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ir a la pagina 3" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />

        </div>
    </form>
</body>
</html>
