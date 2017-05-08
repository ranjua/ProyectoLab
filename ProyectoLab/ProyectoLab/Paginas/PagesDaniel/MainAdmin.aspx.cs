using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLab.Paginas.PagesDaniel
{
    public partial class MainAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddMedico_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddMedico.aspx", true);
        }

        protected void btnDeleteMedico_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteMedico.aspx", true);
        }

        protected void btnModMedico_Click(object sender, EventArgs e)
        {
            Server.Transfer("ModMedico.aspx", true);
        }

        protected void btnAddEnfermero_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddEnfermero.aspx", true);
        }

        protected void btnDeleteEnfermero_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteEnfermero.aspx", true);
        }

        protected void btnModEnfermero_Click(object sender, EventArgs e)
        {
            Server.Transfer("ModEnfermero.aspx", true);
        }

        protected void btnAgregarCita_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddCita.aspx", true);
        }

        protected void btnDeleteCita_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteCita.aspx", true);
        }

        protected void btnModCita_Click(object sender, EventArgs e)
        {
            Server.Transfer("ModCita.aspx", true);
        }
    }
}