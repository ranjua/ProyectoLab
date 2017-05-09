using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ProyectoLab.Clases;
namespace ProyectoLab.Paginas.Medico
{
    public partial class VerCitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cod_Usuario"] != null && Session["Cod_Usuario"].ToString() != "" && Session["Cod_Rol"].ToString() == "2")
            {
                initElements();    
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        private void initElements() 
        {
            Clases.Medico med = new Clases.Medico();
            String dpi = Session["Cod_Usuario"].ToString();
            DataTable tabla = med.verDatosMedico(dpi);
            if(tabla.Rows.Count > 0)
            {
                DataRow row = tabla.Rows[0];
                lbnombreMedico.Text = row["Nombre"].ToString();    
            }
        }

        protected void btn_verCitas(object sender, EventArgs e)
        {
            String dpiMedico = Session["Cod_Usuario"].ToString();
            Clases.Cita bscita = new Clases.Cita();
            DataTable citas = bscita.verCitasporMedico(dpiMedico);
            foreach (DataRow row in citas.Rows) 
            {
                String fecha = row["Fecha"].ToString();
                String hora = row["Hora"].ToString();
                String sala = row["Sala"].ToString();
                String observaciones = row["Observaciones"].ToString();
                String cod_Cita = row["cod_Cita"].ToString();
                TableRow datoCita = new TableRow();
                TableCell colFecha = new TableCell();
                colFecha.Text = fecha;
                datoCita.Cells.Add(colFecha);
                TableCell colHora = new TableCell();
                colHora.Text = hora;
                datoCita.Cells.Add(colHora);
                TableCell colSala = new TableCell();
                colSala.Text = sala;
                datoCita.Cells.Add(colSala);
                TableCell colObser = new TableCell();
                colObser.Text = observaciones;
                datoCita.Cells.Add(colObser);
                TableCell colVer= new TableCell();
                colVer.Text = "<a href=\"ModificarCita.aspx?val=" + cod_Cita + "\"> Modificar </a>";
                datoCita.Cells.Add(colVer);
                tablaCita.Rows.Add(datoCita);
            }
        }
    }
}