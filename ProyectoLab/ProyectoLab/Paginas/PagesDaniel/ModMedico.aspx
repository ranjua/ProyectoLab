<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModMedico.aspx.cs" Inherits="ProyectoLab.Paginas.PagesDaniel.ModMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                 <h1>Modificar Medico</h1>
        <table>
            <tr>
                <th>Dpi del Medico:</th>
                <th>
                    <asp:TextBox ID="txtDpi" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th>Datos a Modificar:</th>                
            </tr>
            
            <tr>
                <th>Nombre:</th>
                <th>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th>Contraseña:</th>
                <th>
                    <asp:TextBox ID="txtContrasenia" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th>Fecha de Nacimientos:</th>
                <th>
                    <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th>Telefono:</th>
                <th>
                    <asp:TextBox ID="txtTelefono" Type="Number" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th>Email:</th>
                <th>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></th>
            </tr>
            <tr>
                <th></th>
                <th>
                    <asp:Button ID="btnModMedico" runat="server" Text="Modificar" OnClick="btnModMedico_Click" /></th>
                    
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
