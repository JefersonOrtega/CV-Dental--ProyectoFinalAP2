using Microsoft.VisualStudio.TestTools.UnitTesting;
using CVDentalSteticSystem.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using CVDentalSteticSystem.Models;

namespace CVDentalSteticSystem.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuario = new Usuarios();
            bool paso = false;

            usuario.UsuarioId = 0;
            usuario.Fecha = DateTime.Now;
            usuario.Nombres = "Juan";
            usuario.Usuario = "Juan01";
            usuario.Contrasena = "J010101";
            usuario.NivelAcceso = "Administrador";

            paso = UsuariosBLL.Guardar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = UsuariosBLL.Existe(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios usuario = new Usuarios();
            bool paso = false;

            usuario.UsuarioId = 0;
            usuario.Fecha = DateTime.Now;
            usuario.Nombres = "Pedro";
            usuario.Usuario = "Pedro058";
            usuario.Contrasena = "Pedro_58";
            usuario.NivelAcceso = "Administrador";

            paso = UsuariosBLL.Insertar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Usuarios usuario = new Usuarios();
            bool paso = false;

            usuario.UsuarioId = 2;
            usuario.Fecha = DateTime.Now;
            usuario.Nombres = "Pedro";
            usuario.Usuario = "Pedro058";
            usuario.Contrasena = "Pedro_5822";
            usuario.NivelAcceso = "Administrador";

            paso = UsuariosBLL.Modificar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = UsuariosBLL.Eliminar(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Usuarios usuario;

            usuario = UsuariosBLL.Buscar(1);

            if (usuario != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso = false;

            List<Usuarios> lista = UsuariosBLL.GetList(p => true);

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetUsuariosTest()
        {
            bool paso = false;

            List<Usuarios> lista = UsuariosBLL.GetUsuarios();

            if (lista != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetNivelTest()
        {
            bool paso = false;

            var usuario = UsuariosBLL.GetNivel("admin");

            paso = (usuario == "Administrador");

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ConfirmacionUsuarioTest()
        {
            bool paso = false;

            paso = UsuariosBLL.ConfirmacionUsuario("admin", "admin");

            Assert.AreEqual(paso, true);
        }
    }
}