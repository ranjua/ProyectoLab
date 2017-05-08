using ProyectoLab.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoLab.Clases
{
    public class SolicitarCita
    {
        BDService bdService = new BDService();

        public bool agregarSolicitud(string dpi)
        {
            DataTable tabla = bdService.FillTableData("select Dpi, Nombre, Fecha_Nacimiento, Telefono, Email, Tarjeja from dbo.Usuario where Dpi=" + dpi + " and cod_tipo = 4");
            foreach (DataRow drtabla in tabla.Rows)
            {
                bdService.Upd_New_DelUnValorQry("insert into dbo.SolicitudCita (Dpi, Fecha) values('"+dpi+"','"+DateTime.Now+"')");
                return true;
            }


            return false; ;

        }

        public DataTable getCita(string dpi)
        {
            DataTable tabla = bdService.FillTableData("select u.nombre as Doctor, c.sala, c.Fecha, c.Hora, c.Observaciones " +
                    " from dbo.Cita c, dbo.Agenda_Cita ac, dbo.Usuario u where " +
                    " ac.Dpi_Medico = u.Dpi and ac.cod_Cita = c.cod_Cita and " +
                    " ac.Dpi_Paciente = " + dpi);
            return tabla;
        }

    }
}