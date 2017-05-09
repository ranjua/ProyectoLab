using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProyectoLab.Paginas.Medico
{
    public partial class ModificarCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String valor = Request.QueryString["val"].ToString();
            Session["cita"] = valor;
            if(!IsPostBack)
            {
                initComponents(valor);
            }
        }

        private void initComponents(String cita) 
        {
            Clases.Cita bscita = new Clases.Cita();
            DataTable citas = bscita.verCita(cita);
            foreach (DataRow row in citas.Rows)
            {
                txt_Fecha.Text = row["Fecha"].ToString();
                txtHora.Text = row["Hora"].ToString();
                txtsala.Text = row["Sala"].ToString();
                txtObservaciones.Text = row["Observaciones"].ToString();
            }
    
        }

        protected void btn_Guardar(object sender, EventArgs e)
        {
            String fecha = txt_Fecha.Text.Trim();
            String sala = txtsala.Text.Trim();
            String hora = txtHora.Text.Trim();
            String obser = txtObservaciones.Text.Trim();
            String cita = Session["cita"].ToString();
            Clases.Cita bscita = new Clases.Cita();
            bscita.actualizarCita(cita,fecha,hora,sala,obser);
        }
        
    }
}