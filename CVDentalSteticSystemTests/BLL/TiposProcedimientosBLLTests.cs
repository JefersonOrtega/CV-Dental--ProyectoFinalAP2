using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class TiposProcedimientosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TiposProcedimientos tipoProcedimiento = new TiposProcedimientos();
            bool paso = false;

            tipoProcedimiento.TipoProcedimientoId = 0;
            tipoProcedimiento.NombreProcedimiento = "Limpieza";
            tipoProcedimiento.Descripcion = "Se realiza un procedimiento de limpieza";
            tipoProcedimiento.Precio = 500;

            paso = TiposProcedimientosBLL.Guardar(tipoProcedimiento);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = TiposProcedimientosBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {

            TiposProcedimientos tipoProcedimiento = new TiposProcedimientos();
            bool paso = false;

            tipoProcedimiento.TipoProcedimientoId = 0;
            tipoProcedimiento.NombreProcedimiento = "Endodoncia";
            tipoProcedimiento.Descripcion = "Consiste en la extirpación de la pulpa dental y el posterior relleno y sellado de la cavidad pulpar con un material inerte.";
            tipoProcedimiento.Precio = 2500;

            paso = TiposProcedimientosBLL.Insertar(tipoProcedimiento);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            TiposProcedimientos tipoProcedimiento = new TiposProcedimientos();
            bool paso = false;

            tipoProcedimiento.TipoProcedimientoId = 1;
            tipoProcedimiento.NombreProcedimiento = "Endodoncia";
            tipoProcedimiento.Descripcion = "El procedimiento consiste en extraer la parte de la pulpa dental completamente";
            tipoProcedimiento.Precio = 2500;

            paso = TiposProcedimientosBLL.Modificar(tipoProcedimiento);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            TiposProcedimientos tipoProcedimiento;

            tipoProcedimiento = TiposProcedimientosBLL.Buscar(2);

            if (tipoProcedimiento != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = TiposProcedimientosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<TiposProcedimientos> lista = TiposProcedimientosBLL.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetTiposProcedimientosTest()
        {
            bool paso = false;

            List<TiposProcedimientos> lista = TiposProcedimientosBLL.GetTiposProcedimientos();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}