<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/Paciente/paciente.Master" AutoEventWireup="true" CodeBehind="SolicitarCita.aspx.cs" Inherits="ProyectoLab.Paginas.Paciente.SolicitarCita" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
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

                    <div class="card-content">
                        <span class="card-title">Solicitar Una Cita </span>
                        
                    <cc1:CaptchaControl ID="Captcha1" runat="server"
                        CaptchaBackgroundNoise="Low" CaptchaLength="5"
                        CaptchaHeight="60" CaptchaWidth="200"
                        CaptchaLineNoise="None" CaptchaMinTimeout="5"
                        CaptchaMaxTimeout="240" FontColor="#529E00" />
                        <input placeholder="Ingrese Captcha" id="txt_Captcha" type="text" class="validate" runat="server" >
                        <br />
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                        <asp:Button ID="btn_Solicitar" runat="server" Text="Solicitar Cita" class="waves-effect waves-light btn" OnClick="btn_Solicitar_Click" />
                    </div>
                </div>
            </div>
        </div>
        
    </div>

</asp:Content>
