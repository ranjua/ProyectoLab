using ProyectoLab.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoLab.Clases
{
    public class ConsultarDatosPaciente
    {

        BDService bdService = new BDService();
        public DataTable buscarPaciente(string dpi)
        {
            
            DataTable tabla = bdService.FillTableData("select Dpi, Nombre, Fecha_Nacimiento, Telefono, Email, Tarjeja from dbo.Usuario where Dpi=" + dpi + " and cod_tipo = 4");
            
            return tabla;
        }
    }
}