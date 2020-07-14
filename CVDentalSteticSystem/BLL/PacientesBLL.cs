using CVDentalSteticSystem.DAL;
using CVDentalSteticSystem.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.BLL
{
    public class PacientesBLL
    {
        public static bool Guardar(Pacientes paciente)
        {
            if (!Existe(paciente.PacienteId))
                return Insertar(paciente);
            else
                return Modificar(paciente);
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Pacientes.Any(e => e.PacienteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        private static bool Insertar(Pacientes paciente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Pacientes.Add(paciente);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Pacientes pacientes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(pacientes).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var paciente = contexto.Pacientes.Find(id);

                if (paciente != null)
                {
                    contexto.Pacientes.Remove(paciente);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Pacientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pacientes paciente;

            try
            {
                paciente = contexto.Pacientes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paciente;
        }

        public static List<Pacientes> GetList(Expression<Func<Pacientes, bool>> criterio)
        {
            List<Pacientes> lista = new List<Pacientes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Pacientes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Pacientes> GetPacientes()
        {
            List<Pacientes> lista = new List<Pacientes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Pacientes.ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
