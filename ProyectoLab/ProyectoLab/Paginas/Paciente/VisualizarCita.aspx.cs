using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLab.Paginas.Paciente
{
    public partial class VisualizarCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (Session["Cod_Usuario"] != null && Session["Cod_Usuario"].ToString() != "" &&
                Session["Cod_Rol"].ToString() == "4")
            {
                if (!IsPostBack)
                {
                    Clases.SolicitarCita sC = new Clases.SolicitarCita();
                    DataTable tabla = sC.getCita(Session["Cod_Usuario"].ToString());
                    foreach (DataRow drtabla in tabla.Rows)
                    {
                        lbl_Doctor.Text = drtabla[0].ToString();
                        lbl_Sala.Text = drtabla[1].ToString();
                        lbl_fecha.Text = drtabla[2].ToString().Substring(0,10);
                        lbl_Hora.Text = drtabla[3].ToString();
                        lbl_Observaciones.Text = drtabla[4].ToString();
                    }

                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            */
        }
             
    }
}