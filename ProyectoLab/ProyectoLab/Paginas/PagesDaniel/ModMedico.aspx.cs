using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLab.Paginas.PagesDaniel
{
    public partial class ModMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModMedico_Click(object sender, EventArgs e)
        {
            String SqlConection = Conexio.cadenaConexion;
            String Comando = "UPDATE Usuario SET Nombre = '" + txtNombre.Text + "',Contrasenia ='" + txtContrasenia.Text + "' ,Fecha_Nacimiento ='" + txtNacimiento.Text + "' ,Telefono = '" + txtTelefono.Text + "',Email = '" + txtEmail.Text + "' WHERE DPI = " + txtDpi.Text + ";";
            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection(SqlConection);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = Comando;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Server.Transfer("MainAdmin.aspx", true);
        }
    }
}