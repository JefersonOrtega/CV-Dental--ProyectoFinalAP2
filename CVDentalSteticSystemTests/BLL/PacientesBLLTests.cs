using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class PacientesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Pacientes paciente = new Pacientes();
            paciente.PacienteId = 3;
            paciente.Nombres = "Juana Diaz";
            paciente.Apellidos = "Hernandez";
            paciente.Direccion = "C/ Cruz #10 Villa Riva";
            paciente.Telefono = "829-654-5698";
            paciente.Email = "j123@gmail.com";
            paciente.Genero = "Femenino";
            paciente.FechaNacimiento = DateTime.Now;
            paciente.FechaRegistro = DateTime.Now;
            paciente.SeguroId = 1;
            paciente.Balance = 0;

            paso = PacientesBLL.Guardar(paciente);
            Assert.AreEqual(paso, true);
        }

      
        [TestMethod()]
        public void InsertarTest()
        {
            bool paso = false;
            Pacientes paciente = new Pacientes();
            paciente.PacienteId = 0;
            paciente.Nombres = "Juan Jose";
            paciente.Apellidos = "Mercedes Santos";
            paciente.Direccion = "C/ Castillo #56 Villa Riva";
            paciente.Telefono = "829-654-6665";
            paciente.Email = "jjms@gmail.com";
            paciente.Genero = "Masculino";
            paciente.FechaNacimiento = DateTime.Now;
            paciente.FechaRegistro = DateTime.Now;
            paciente.SeguroId = 1;
            paciente.Balance = 0;

            paso = PacientesBLL.Insertar(paciente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PacientesBLL.Existe(3);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Pacientes paciente = new Pacientes();
            paciente.PacienteId = 2;
            paciente.Nombres = "Juan Alberto";
            paciente.Apellidos = "Peña Santos";
            paciente.Direccion = "C/ Castillo #58 Villa Riva";
            paciente.Telefono = "829-654-6665";
            paciente.Email = "jjms@gmail.com";
            paciente.Genero = "Masculino";
            paciente.FechaNacimiento = DateTime.Now;
            paciente.FechaRegistro = DateTime.Now;
            paciente.SeguroId = 1;
            paciente.Balance = 0;

            paso = PacientesBLL.Modificar(paciente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = PacientesBLL.Eliminar(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Pacientes pacientes;

            pacientes = PacientesBLL.Buscar(2);

            if (pacientes != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Pacientes> lista = PacientesBLL.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetPacientesTest()
        {
            bool paso = false;

            List<Pacientes> lista = PacientesBLL.GetPacientes();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}