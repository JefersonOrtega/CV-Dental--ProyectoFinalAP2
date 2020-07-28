using CVDentalSteticSystem.DAL;
using CVDentalSteticSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.BLL
{
    public class CitasBLL
    {
        public static bool Guardar(Citas cita)
        {
            if (!Existe(cita.CitaId))
            {
                return Insertar(cita);
            }
            else
            {
                return Modificar(cita);
            }      
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Citas.Any(c => c.CitaId == id);
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

        private static bool Insertar(Citas cita)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Citas.Add(cita);
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

        private static bool Modificar(Citas cita)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(cita).State = EntityState.Modified;
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
                var cita = contexto.Citas.Find(id);

                if (cita != null)
                {
                    contexto.Citas.Remove(cita);
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

        public static Citas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Citas cita;

            try
            {
                cita = contexto.Citas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return cita;
        }

        public static List<Citas> GetList(Expression<Func<Citas, bool>> criterio)
        {
            List<Citas> lista = new List<Citas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Citas.Where(criterio).ToList();
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

        public static List<Citas> GetCitas()
        {
            List<Citas> lista = new List<Citas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Citas.ToList();
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
    }
}
