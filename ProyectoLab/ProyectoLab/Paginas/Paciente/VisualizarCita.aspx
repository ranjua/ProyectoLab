<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/Paciente/paciente.Master" AutoEventWireup="true" CodeBehind="VisualizarCita.aspx.cs" Inherits="ProyectoLab.Paginas.Paciente.VisualizarCita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav>
    <div class="nav-wrapper">
      <a href="#" class="brand-logo">AYD1MEDIPLUS</a>
      <ul id="nav-mobile" class="right ">
        <li><a href="SolicitarCita.aspx">Solicitar Cita</a></li>
        <li><a href="VisualizarCita.aspx">Visualizar Cita</a></li>
        <li><a href="../../Login.aspx">Logout</a></li>
      </ul>
    </div>
  </nav>
    <div class="container">
        <div class="row">
            <div class="col s12 m7">
                <div class="card">
                    <div class="card-image">
                        <img src="../../Img/Caledario.jpg">
                        <span class="card-title">Detalles de Cita</span>
                    </div>
                    <div class="card-content">
                        <span class="card-title">Doctor</span>
                        <p><asp:Label ID="lbl_Doctor" runat="server" Text=""></asp:Label></p>

                        <span class="card-title">Sala</span>
                        <p><asp:Label ID="lbl_Sala" runat="server" Text=""></asp:Label></p>

                        <span class="card-title">Fecha de Cita</span>
                        <p><asp:Label ID="lbl_fecha" runat="server" Text=""></asp:Label></p>

                        <span class="card-title">Hora de Cita</span>
                        <p><asp:Label ID="lbl_Hora" runat="server" Text=""></asp:Label></p>

                        <span class="card-title">Observaciones</span>
                        <p><asp:Label ID="lbl_Observaciones" runat="server" Text=""></asp:Label></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
