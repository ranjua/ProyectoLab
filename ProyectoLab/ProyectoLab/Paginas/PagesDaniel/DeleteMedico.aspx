<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteMedico.aspx.cs" Inherits="ProyectoLab.Paginas.PagesDaniel.DeleteMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Eliminar Medico</h1>
        <table>
            <tr>
                <th>Dpi del Medico:</th>
                <th>
                    <asp:TextBox ID="txtDpi" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th></th>
                <th>
                    <asp:Button ID="btnDeleteMedico" runat="server" Text="Eliminar" OnClick="btnDeleteMedico_Click" /></th>
                    
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
