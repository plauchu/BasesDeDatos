<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_EF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejemplo de uso de EF.</title>
    <style type="text/css">
        #form1 {
            height: 541px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" title="Ejemplo de uso de EF Web">
        <div style="height: 424px; background-color: #FF5050">
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="Login1_Authenticate" style="z-index: 1; left: 103px; top: 80px; position: absolute; height: 132px; width: 264px">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
        </div>
    </form>
</body>
</html>
