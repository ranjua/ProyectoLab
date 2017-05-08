<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/Medico/medico.Master" AutoEventWireup="true" CodeBehind="VerCitas.aspx.cs" Inherits="ProyectoLab.Paginas.Medico.VerCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
        <div class="col s12 m7">
          <div class="card">
            
              <p>Bienvenido Doctor  <asp:Label ID="lbnombreMedico" runat="server" Text=""></asp:Label></p>
            <div class="card-content">
                <span class="card-title"> Ver Citas </span>
                <br />
                <asp:Button ID="btnCitas" runat="server" Text="Ver Cita" class="waves-effect waves-light btn" OnClick="btn_verCitas" />
            </div>
          </div>
        </div>
      </div>
         <div class="row">
        <div class="col  m12">
          <div class="card">
            <div class="card-content">
                <asp:Table ID="tablaCita" runat="server" >
                    <asp:TableRow >
                        <asp:TableCell>
                            <h3>Fecha</h3>
                        </asp:TableCell>
                        <asp:TableCell>
                            <h3>Hora</h3>
                        </asp:TableCell>
                        <asp:TableCell>
                            <h3>Sala</h3>
                        </asp:TableCell>
                        <asp:TableCell>
                            <h3>Observaciones</h3>
                        </asp:TableCell>
                        <asp:TableCell>
                            <h3>Ver</h3>
                        </asp:TableCell>
                        <asp:TableCell Enabled ="false">
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
