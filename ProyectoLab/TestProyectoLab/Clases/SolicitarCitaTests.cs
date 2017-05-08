using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            SolicitarCita sC = new SolicitarCita();
            bool resultado = sC.agregarSolicitud(dpi);

            Assert.AreEqual(esperado, resultado);
        }
    }
}