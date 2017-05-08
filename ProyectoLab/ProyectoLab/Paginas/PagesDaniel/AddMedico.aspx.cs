using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLab.Paginas.PagesDaniel
{
    public partial class AddMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            String SqlConection = "";
            String Comando = "INSERT Usuario (DPI,Nombre,Contraseña,Fecha_Nacimiento,Telefono,Email,cod_Tipo) VALUES (" + txtDpi.Text + ",'" + txtNombre.Text + "','" + txtContrasenia.Text + "','" + txtNacimiento.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "',2)";
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


    }
}