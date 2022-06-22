<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaPréstamos.aspx.cs" Inherits="Web_EF.ListaPréstamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 333px;
            background-color: #99FF33;
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
            width: 409px;
        }
        #ddlP {
            height: 537px;
            background-color: #CC99FF;
        }
        .auto-style1 {
            width: 88%;
            z-index: 1;
            left: 74px;
            top: 285px;
            position: absolute;
            height: 11px;
        }
        .auto-style2 {
            position: absolute;
            left: 12px;
            top: 17px;
        }
    </style>
</head>
<body style="height: 389px; width: 891px;">
    <form id="ddlP" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 382px; top: 49px; position: absolute" Text="Péstamos de clientes."></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" style="z-index: 1; left: 28px; top: 509px; position: absolute">Página principal</asp:HyperLink>
        <asp:Table ID="tblCliente" runat="server" style="z-index: 1; left: 301px; top: 102px; position: absolute; height: 58px; width: 248px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">RFC</asp:TableCell>
                <asp:TableCell runat="server">Nombre</asp:TableCell>
                <asp:TableCell runat="server">Domicilio</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 568px; top: 114px; position: absolute; height: 21px" Text="Préstamos:"></asp:Label>
        <asp:Table ID="tblF" runat="server" style="z-index: 1; left: 321px; top: 217px; position: absolute; height: 25px; width: 30px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Folio</asp:TableCell>
                <asp:TableCell runat="server">Monto</asp:TableCell>
                <asp:TableCell runat="server">Mensualidad</asp:TableCell>
                <asp:TableCell runat="server">Saldo</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:DropDownList ID="ddlPréstamos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPréstamos_SelectedIndexChanged" style="z-index: 1; left: 661px; top: 114px; position: absolute; bottom: 224px; width: 159px">
        </asp:DropDownList>
        <table class="auto-style1">
            <tr style="z-index: 1">
                <td class="auto-style2">
                    <asp:GridView ID="grdPagos" runat="server" EmptyDataText="No hay pagos asociados" Width="104px">
                    </asp:GridView>
                </td>
                <td class="auto-style2">
                    <asp:GridView ID="grdAvales" runat="server" EmptyDataText="No hay avales asociados">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
