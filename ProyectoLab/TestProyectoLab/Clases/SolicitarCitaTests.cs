using ProyectoLab.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace ProyectoLab.Clases.Tests
{
    [TestClass()]
    public class SolicitarCitaTests
    {
        [TestMethod()]
        public void agregarSolicitudTest()
        {
            var dpi = "30001";
            bool esperado = true;
           // SolicitarCita sC = new SolicitarCita();
            //bool resultado = sC.agregarSolicitud(dpi);

            //Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void getCitaTest()
        {
            var dpi = "30001";
            //DataTable noEsperado = null;
           // SolicitarCita sC = new SolicitarCita();
           // DataTable resultado = sC.getCita(dpi);

            //Assert.AreNotEqual(noEsperado, resultado);


        }
    }
}