using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class ProcedimientosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Procedimientos procedimiento = new Procedimientos();
            ProcedimientosDetalles detalle = new ProcedimientosDetalles();
            bool paso = false;

            procedimiento.ProcedimientoId = 0;
            procedimiento.PacienteId = 3;
            procedimiento.TipoProcedimientoId = 1;
            procedimiento.Estado = "En Proceso";

            detalle.ProcedimientosDetalleId = 0;
            detalle.ProcedimientoId = 2;
            detalle.CitaId = 1;
            detalle.Descripcion = "Se realizaron avances en...";


            procedimiento.ProcedimientoDetalle.Add(detalle);

            paso = ProcedimientosBLL.Guardar(procedimiento);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = ProcedimientosBLL.Existe(9);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Procedimientos procedimiento = new Procedimientos();
            ProcedimientosDetalles detalle = new ProcedimientosDetalles();
            bool paso = false;

            procedimiento.ProcedimientoId = 0;
            procedimiento.PacienteId = 3;
            procedimiento.TipoProcedimientoId = 1;
            procedimiento.Estado = "En Proceso";

            detalle.ProcedimientosDetalleId = 0;
            detalle.ProcedimientoId = 2;
            detalle.CitaId = 2;
            detalle.Descripcion = "Se inicio el procedimiento";


            procedimiento.ProcedimientoDetalle.Add(detalle);

            paso = ProcedimientosBLL.Insertar(procedimiento);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Procedimientos procedimiento = new Procedimientos();
            ProcedimientosDetalles detalle = new ProcedimientosDetalles();
            bool paso = false;

            procedimiento.ProcedimientoId = 8;
            procedimiento.PacienteId = 3;
            procedimiento.TipoProcedimientoId = 1;
            procedimiento.Estado = "Concluido";

            detalle.ProcedimientosDetalleId = 0;
            detalle.ProcedimientoId = 2;
            detalle.CitaId = 3;
            detalle.Descripcion = "Se concluyo el procedimiento";


            procedimiento.ProcedimientoDetalle.Add(detalle);

            paso = ProcedimientosBLL.Modificar(procedimiento);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = ProcedimientosBLL.Eliminar(9);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Procedimientos procedimientos;

            procedimientos = ProcedimientosBLL.Buscar(9);

            if (procedimientos != null)
                paso = true;

            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Procedimientos> lista = ProcedimientosBLL.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetProcedimientosTest()
        {
            bool paso = false;

            List<Procedimientos> lista = ProcedimientosBLL.GetProcedimientos();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}