using CVDentalSteticSystem.DAL;
using CVDentalSteticSystem.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.BLL
{
    public class CobrosBLL
    {
        public static bool Guardar(Cobros cobros)
        {
            if (!Existe(cobros.CobroId))
            {
                return Insertar(cobros);
            }
            else
            {
                return Modificar(cobros);
            }
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Cobros.Any(c => c.CobroId == id);
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

        private static bool Insertar(Cobros cobros)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Pacientes paciente = PacientesBLL.Buscar(cobros.PacienteId);
                paciente.Balance -= cobros.Monto;


                contexto.Entry(paciente).State = EntityState.Modified;
                contexto.Cobros.Add(cobros);
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

        private static bool Modificar(Cobros cobros)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM CobroDetalles where CobroId = {cobros.CobroId}");

                foreach (var item in cobros.CobroDetalles)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(cobros).State = EntityState.Modified;
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
                var cobro = contexto.Cobros.Find(id);

                if (cobro != null)
                {
                    contexto.Cobros.Remove(cobro);
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

        public static Cobros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Cobros cobro;

            try
            {
                cobro = contexto.Cobros
                        .Where(c => c.CobroId == id)
                        .Include(cd => cd.CobroDetalles)
                        .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return cobro;
        }

        public static List<Cobros> GetList(Expression<Func<Cobros, bool>> criterio)
        {
            List<Cobros> lista = new List<Cobros>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Cobros.Where(criterio).ToList();
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

        public static List<Cobros> GetCitas()
        {
            List<Cobros> lista = new List<Cobros>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Cobros.ToList();
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

        public static void PagarMonto(int id, decimal monto)
        {
            Contexto contexto = new Contexto();
            var paciente = PacientesBLL.Buscar(id);

            try
            {
                if(paciente != null)
                {
                    paciente.Balance -= monto;
                    PacientesBLL.Guardar(paciente);
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
        }
    }
}

