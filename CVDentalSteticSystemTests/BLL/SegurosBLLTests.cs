using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class SegurosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Seguros seguro = new Seguros();
            bool paso = false;

            seguro.SeguroId = 0;
            seguro.Nombre = "Senasa";

            paso = SegurosBLL.Guardar(seguro);
            
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Seguros seguro = new Seguros();
            bool paso = false;


            seguro.SeguroId = 0;
            seguro.Nombre = "Senasa";

            paso = SegurosBLL.Insertar(seguro);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Seguros seguro = new Seguros();
            bool paso = false;


            seguro.SeguroId = 2;
            seguro.Nombre = "ARS Palic";

            paso = SegurosBLL.Insertar(seguro);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = SegurosBLL.Existe(2);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = SegurosBLL.Eliminar(2);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Seguros seguro;

            seguro = SegurosBLL.Buscar(2);

            if(seguro != null)
            {
                paso = true;
            }

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Seguros> lista = SegurosBLL.GetList(s => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetSegurosTest()
        {
            bool paso = false;

            List<Seguros> lista = SegurosBLL.GetSeguros();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}