<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercice2.aspx.cs" Inherits="Exercice_2__les_contrôles_DropDownList_et_Button.exercice2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="c1">
           
            <br />
            <asp:Label ID="Label1" runat="server" Text="Convertion" Font-Bold="True" Font-Italic="True" ForeColor="#000099"></asp:Label>
            <asp:TextBox ID="txtDollards" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text=" Dollar us en" Font-Bold="True" Font-Italic="True" ForeColor="#000099"></asp:Label>
            <asp:DropDownList ID="drpTypeDevise" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
            <br />
            <br />
            <asp:Label ID="lblDollarsEnDevise" runat="server" BackColor="#00CC00" BorderStyle="Double"></asp:Label>
            <br />
            <asp:Button ID="btnAffichGraph" runat="server" OnClick="Button1_Click" Text="btnAffichGraph" />
            <br />
            <asp:Image ID="imgGraph" runat="server" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
