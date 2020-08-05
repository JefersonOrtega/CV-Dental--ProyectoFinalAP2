using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class CitasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Citas cita = new Citas();
            bool paso = false;

            cita.CitaId = 0;
            cita.TipoCitaId = 1;
            cita.PacienteId = 1;
            cita.Observacion = "Hay que hacerle una limpiezaq profunda";
            cita.Estado = true;
            cita.Fecha = DateTime.Now;

            paso = CitasBLL.Guardar(cita);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Citas cita = new Citas();
            bool paso = false;

            cita.CitaId = 0;
            cita.TipoCitaId = 1;
            cita.PacienteId = 1;
            cita.Observacion = "Hay que hacerle una limpiezaq profunda";
            cita.Estado = true;
            cita.Fecha = DateTime.Now;

            paso = CitasBLL.Guardar(cita);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Citas cita = new Citas();
            bool paso = false;

            cita.CitaId = 0;
            cita.TipoCitaId = 1;
            cita.PacienteId = 1;
            cita.Observacion = "Hay que hacerle una limpieza profunda";
            cita.Estado = false;
            cita.Fecha = DateTime.Now;

            paso = CitasBLL.Modificar(cita);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = CitasBLL.Existe(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = CitasBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Citas cita;

            cita = CitasBLL.Buscar(1);

            if(cita != null)
            {
                paso = true;
            }

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Citas> lista = CitasBLL.GetList(c => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetCitasTest()
        {
            bool paso = false;
            List<Citas> lista = CitasBLL.GetCitas();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}