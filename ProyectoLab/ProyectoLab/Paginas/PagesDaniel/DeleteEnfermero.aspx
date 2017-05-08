<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteEnfermero.aspx.cs" Inherits="ProyectoLab.Paginas.PagesDaniel.DeleteEnfermero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Eliminar Enfermero</h1>
        <table>
            <tr>
                <th>Dpi del Enfermero:</th>
                <th>
                    <asp:TextBox ID="txtDpi" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th></th>
                <th>
                    <asp:Button ID="btnDeleteEnfermero" runat="server" Text="Eliminar" OnClick="btnDeleteEnfermero_Click" /></th>
                    
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
