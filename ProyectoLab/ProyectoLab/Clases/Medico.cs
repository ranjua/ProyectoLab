using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoLab.Servicios;
namespace ProyectoLab.Clases
{
    public class Medico
    {
        BDService serviciosBD = new BDService();
        public DataTable verDatosMedico(string dpiMedico)
        {

            DataTable tabla = serviciosBD.FillTableData("SELECT Dpi, Nombre, Fecha_Nacimiento, Telefono, Email, Tarjeja from dbo.Usuario WHERE Dpi=" + dpiMedico + " and cod_tipo = 2");
            return tabla;
        }
        
    }
}