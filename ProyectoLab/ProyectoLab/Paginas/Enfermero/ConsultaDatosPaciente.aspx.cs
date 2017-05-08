using System;
using System.Data;

namespace ProyectoLab.Paginas.Enfermero
{
    public partial class ConsultaDatosPaciente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
                if (Session["Cod_Usuario"] != null && Session["Cod_Usuario"].ToString() != "" &&
                Session["Cod_Rol"].ToString() == "3")
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

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            lbl_dpi.Text = "";
            lbl_Nombre.Text = "";
            lbl_FechaN.Text = "";
            lbl_telefono.Text = "";
            lbl_email.Text = "";

            Clases.ConsultarDatosPaciente cDP = new Clases.ConsultarDatosPaciente();
            DataTable tabla = cDP.buscarPaciente(txt_dpi.Value);

            foreach (DataRow drtabla in tabla.Rows)
            {
                lbl_dpi.Text = drtabla[0].ToString();
                lbl_Nombre.Text = drtabla[1].ToString();
                lbl_FechaN.Text = drtabla[2].ToString();
                lbl_telefono.Text = drtabla[3].ToString();
                lbl_email.Text = drtabla[4].ToString();
            }
        }

        
    }
}