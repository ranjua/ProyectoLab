<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/Medico/medico.Master" AutoEventWireup="true" CodeBehind="ModificarCita.aspx.cs" Inherits="ProyectoLab.Paginas.Medico.ModificarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col s12 m7">
          <div class="card">
            <div class="card-content">
                <span class="card-title"> Fecha </span>
              <p><asp:TextBox ID="txt_Fecha" runat="server" Text=""></asp:TextBox></p>
                <span class="card-title">Sala </span>
              <p><asp:TextBox ID="txtsala" runat="server" Text=""></asp:TextBox></p>
                <span class="card-title">Hora </span>
              <p><asp:TextBox ID="txtHora" runat="server" Text=""></asp:TextBox></p>
                <span class="card-title">Observaciones </span>
              <p><asp:TextBox ID="txtObservaciones" runat="server" Text=""></asp:TextBox></p>
            </div>
          </div>
            <div class="card-content">
                <br />
                <asp:Button ID="Guardar" runat="server" Text="Guardar" class="waves-effect waves-light btn" OnClick="btn_Guardar" />
            </div>
        </div>
      </div>
</asp:Content>
