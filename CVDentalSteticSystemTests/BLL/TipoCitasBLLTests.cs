using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class TipoCitasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TipoCitas tipoCitas = new TipoCitas();
            bool paso = false;

            tipoCitas.TipoCitaId = 0;
            tipoCitas.Nombre = "Urgente";
            tipoCitas.Descripcion = "Esta es una breve descripcion";

            paso = TipoCitasBLL.Guardar(tipoCitas);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            TipoCitas tipoCitas = new TipoCitas();
            bool paso = false;

            tipoCitas.TipoCitaId = 0;
            tipoCitas.Nombre = "Urgente";
            tipoCitas.Descripcion = "Esta es una breve descripcion";

            paso = TipoCitasBLL.Insertar(tipoCitas);

            Assert.AreEqual(paso, true);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            TipoCitas tipoCitas = new TipoCitas();
            bool paso = false;

            tipoCitas.TipoCitaId = 2;
            tipoCitas.Nombre = "Agendada";
            tipoCitas.Descripcion = "Esta es una breve descripcion";

            paso = TipoCitasBLL.Modificar(tipoCitas);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = TipoCitasBLL.Existe(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = TipoCitasBLL.Eliminar(2);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            TipoCitas tipoCitas;

            tipoCitas = TipoCitasBLL.Buscar(1);

            if(tipoCitas != null)
            {
                paso = true;
            }

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<TipoCitas> lista = TipoCitasBLL.GetList(tp => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetTipoCitasTest()
        {
            bool paso = false;

            List<TipoCitas> lista = TipoCitasBLL.GetTipoCitas();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}