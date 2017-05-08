using ProyectoLab.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
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
                Session["Cod_Usuario"] = "";
                Session["Cod_Rol"] = "";
            }
        }

        private bool log(string dpi, string pass)
        {
            BDService bdService = new BDService();
            DataTable tabla = bdService.FillTableData("select contrasenia, cod_tipo from dbo.Usuario where dpi = " + dpi);
            try
            {
                if (pass == tabla.Rows[0][0].ToString())
                {
                    Session["Cod_Usuario"] = dpi;
                    Session["Cod_Rol"] = tabla.Rows[0][1].ToString();
                    return true;
                }
            }
            catch (Exception)
            {
               
            }


            return false;
        }

        protected void registrobutton_Click(object sender, EventArgs e)
        {

            if (log(txt_dpi.Value, txt_pass.Value))
            {
                if (Session["Cod_Rol"].ToString() == "4")
                {
                    Response.Redirect("/Paginas/Paciente/SolicitarCita.aspx");
                }
                if (Session["Cod_Rol"].ToString() == "3")
                {
                    Response.Redirect("/Paginas/Enfermero/ConsultaDatosPaciente.aspx");
                }
                if (Session["Cod_Rol"].ToString() == "2")
                {

                }
                if (Session["Cod_Rol"].ToString() == "1")
                {

                }
            }

        }
    }
}