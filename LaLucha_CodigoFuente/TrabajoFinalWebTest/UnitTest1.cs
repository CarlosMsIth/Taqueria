using NUnit.Framework;
using TrabajoFinalWeb.Controllers;
using TrabajoFinalWeb.Models;

namespace TrabajoFinalWebTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            EmpleadosController empleados = new EmpleadosController();
            empleados.Create();
            //var moqServiceEmpleados
        }
    }
}