<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="usoControles.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Uso de controles<br />
            <br />
            Colores:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Sabores:<br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            </asp:RadioButtonList>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Café"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Label7" runat="server" Text="índice"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="contenido"></asp:Label>
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <br />
            <br />
            Session--&gt;<asp:Label ID="lblSession" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
