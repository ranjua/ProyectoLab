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
                Session["Cod_Usuario"] = 2222;
                Session["Cod_Rol"] = 2;
                Response.Redirect("/Paginas/Medico/VerCitas.aspx");
            }
        }
    }
}