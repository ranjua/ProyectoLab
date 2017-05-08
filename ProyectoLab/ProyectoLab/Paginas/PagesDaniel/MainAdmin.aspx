<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainAdmin.aspx.cs" Inherits="ProyectoLab.Paginas.PagesDaniel.MainAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Principal</h1>
        <h2> Modo Administrador</h2>
        <table>
            <tr>
                <th>
                    <asp:Button ID="btnAddMedico" runat="server" Text="Agregar Médico" OnClick="btnAddMedico_Click" Width="100%" /></th>
            </tr>
            <tr>
                <th>
                    <asp:Button ID="btnDeleteMedico" runat="server" Text="Eliminar Médico" OnClick="btnDeleteMedico_Click" Width="100%" /></th>
            </tr>
            <tr>
                <th>
                    <asp:Button ID="btnModMedico" runat="server" Text="Modificar Médico" OnClick="btnModMedico_Click" Width="100%" /></th>
            </tr>
            <tr>
                <th>
                    <asp:Button ID="btnAddEnfermero" runat="server" Text="Agregar Enfermero" OnClick="btnAddEnfermero_Click" Width="100%" /></th>
            </tr>
             <tr>
                <th>
                    <asp:Button ID="btnDeleteEnfermero" runat="server" Text="Eliminar Enfermero" OnClick="btnDeleteEnfermero_Click" Width="100%" /></th>
            </tr>
             <tr>
                <th>
                    <asp:Button ID="btnModEnfermero" runat="server" Text="Modificar Enfermero" OnClick="btnModEnfermero_Click" /></th>
            </tr>
            <tr>
                <th>
                    <asp:Button ID="btnAgregarCita" runat="server" Text="Agregar Cita" OnClick="btnAgregarCita_Click" Width="100%" /></th>
            </tr>
             <tr>
                <th>
                    <asp:Button ID="btnDeleteCita" runat="server" Text="Eliminar Cita" OnClick="btnDeleteCita_Click" Width="100%" /></th>
            </tr>
             <tr>
                <th>
                    <asp:Button ID="btnModCita" runat="server" Text="Modificar Cita" OnClick="btnModCita_Click" Width="100%" /></th>
            </tr>

        </table>
    </div>
    </form>
</body>
</html>
