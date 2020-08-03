using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;
using System.Drawing.Printing;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class CobrosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cobros cobros = new Cobros();
            CobroDetalles cobroDetalles = new CobroDetalles();
            bool paso = false;

            cobros.CobroId = 0;
            cobros.Fecha = DateTime.Now;
            cobros.PacienteId = 1;
            cobros.ProcedimientoId = 1;
            cobros.Monto = 500;

            cobroDetalles.CobroId = 0;
            cobroDetalles.CobroId = 1;
            cobroDetalles.Descripcion = "Breve descripcion";
            cobroDetalles.Abono = 250;

            cobros.CobroDetalles.Add(cobroDetalles);

            paso = CobrosBLL.Guardar(cobros);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = CobrosBLL.Existe(3);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Cobros cobros = new Cobros();
            CobroDetalles cobroDetalles = new CobroDetalles();
            bool paso = false;

            cobros.CobroId = 0;
            cobros.Fecha = DateTime.Now;
            cobros.PacienteId = 1;
            cobros.ProcedimientoId = 1;
            cobros.Monto = 500;

            cobroDetalles.CobroId = 0;
            cobroDetalles.CobroId = 1;
            cobroDetalles.Descripcion = "Breve descripcion";
            cobroDetalles.Abono = 250;

            cobros.CobroDetalles.Add(cobroDetalles);

            paso = CobrosBLL.Insertar(cobros);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Cobros cobros = new Cobros();
            CobroDetalles cobroDetalles = new CobroDetalles();
            bool paso = false;

            cobros.CobroId = 0;
            cobros.Fecha = DateTime.Now;
            cobros.PacienteId = 1;
            cobros.ProcedimientoId = 1;
            cobros.Monto = 1000;

            cobroDetalles.CobroId = 0;
            cobroDetalles.CobroId = 1;
            cobroDetalles.Descripcion = "Breve descripcion";
            cobroDetalles.Abono = 150;

            cobros.CobroDetalles.Add(cobroDetalles);

            paso = CobrosBLL.Modificar(cobros);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = CobrosBLL.Eliminar(3);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Cobros cobros;

            cobros = CobrosBLL.Buscar(3);

            if (cobros != null)
                paso = true;

            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Cobros> lista = CobrosBLL.GetList(c => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetCitasTest()
        {
            bool paso = false;

            List<Cobros> lista = CobrosBLL.GetCitas();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}