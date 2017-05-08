<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/Enfermero/enfermero.Master" AutoEventWireup="true" CodeBehind="ConsultaDatosPaciente.aspx.cs" Inherits="ProyectoLab.Paginas.Enfermero.ConsultaDatosPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container">
        <div class="row">
        <div class="col s12 m7">
          <div class="card">
            
            <div class="card-content">
                <span class="card-title">Buscar Paciente</span>
                
                  <input placeholder="Ingrese DPI" id="txt_dpi" type="text" class="validate" runat="server">
                <br />
                <asp:Button ID="btn_Buscar" runat="server" Text="Buscar Datos" class="waves-effect waves-light btn" OnClick="btn_Buscar_Click" />
                
            </div>
          </div>
        </div>
      </div>
         <div class="row">
        <div class="col s12 m7">
          <div class="card">
            <div class="card-image">
              <img src="../../Img/paciente.png">
              <span class="card-title black-text">Detalles de Paciente</span>
            </div>
            <div class="card-content">
                <span class="card-title">DPI</span>
              <p><asp:Label ID="lbl_dpi" runat="server" Text=""></asp:Label></p>
                <span class="card-title">Nombre</span>
              <p><asp:Label ID="lbl_Nombre" runat="server" Text=""></asp:Label></p>
                <span class="card-title">Fecha De Nacimiento</span>
              <p><asp:Label ID="lbl_FechaN" runat="server" Text=""></asp:Label></p>
                <span class="card-title">Telefono</span>
              <p><asp:Label ID="lbl_telefono" runat="server" Text=""></asp:Label></p>
                <span class="card-title">Email</span>
              <p><asp:Label ID="lbl_email" runat="server" Text=""></asp:Label></p>
            </div>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
