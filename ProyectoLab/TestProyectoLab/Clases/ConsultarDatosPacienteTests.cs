using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace ProyectoLab.Clases.Tests
{
    [TestClass()]
    public class ConsultarDatosPacienteTests
    {
        [TestMethod()]
        public void buscarPacienteTest()
        {
            var dpi = "30001";
            DataTable noEsperado = null;
            ConsultarDatosPaciente cDP = new ConsultarDatosPaciente();
            DataTable resultado = cDP.buscarPaciente(dpi);

            Assert.AreNotEqual(noEsperado, resultado);
                
        }
    }
}