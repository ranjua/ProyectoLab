using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoLab.Servicios;

namespace ProyectoLab.Clases
{
    public class Cita
    {
        BDService servicioBD = new BDService();

        public DataTable verCitasporMedico(String dpiMedico) 
        {

            String query = "SELECT * FROM dbo.Cita C Where C.cod_Cita in ( SELECT cod_Cita FROM Agenda_Cita WHERE Dpi_Medico = "+dpiMedico+ ")";
            DataTable tabla = servicioBD.FillTableData(query);
            return tabla;
        }
    }
}