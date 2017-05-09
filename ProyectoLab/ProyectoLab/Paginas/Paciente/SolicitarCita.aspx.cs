using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLab.Paginas.Paciente
{
    public partial class SolicitarCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cod_Usuario"] != null && Session["Cod_Usuario"].ToString() != "" &&
                Session["Cod_Rol"].ToString() == "4")
            {
                if (!IsPostBack)
                {

                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btn_Solicitar_Click(object sender, EventArgs e)
        {
            Captcha1.ValidateCaptcha(txt_Captcha.Value.Trim());
            if (Captcha1.UserValidated)
            {
                lblMessage.Text = "Solicitud No Enviada";
                Clases.SolicitarCita sC = new Clases.SolicitarCita();
                if(sC.agregarSolicitud(HttpContext.Current.Session["Cod_Usuario"].ToString()))
                    lblMessage.Text = "Solicitud Enviada";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Captcha Invalido";
            }
        }
    }
}