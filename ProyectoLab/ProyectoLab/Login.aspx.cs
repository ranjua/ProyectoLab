using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLab
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["Cod_Usuario"] = 1;
                Session["Cod_Rol"] = 3;
                //Response.Redirect("/Paginas/Enfermero/ConsultaDatosPaciente.aspx");
                Session["Cod_Usuario"] = 30001;
                Session["Cod_Rol"] = 4;
                //Response.Redirect("/Paginas/Paciente/SolicitarCita.aspx");
                Session["Cod_Usuario"] = 30001;
                Session["Cod_Rol"] = 4;
                Response.Redirect("/Paginas/Paciente/VisualizarCita.aspx");
            }
        }
    }
}