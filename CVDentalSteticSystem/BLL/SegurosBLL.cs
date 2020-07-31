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
    public class SegurosBLL
    {
        public static bool Guardar(Seguros seguro)
        {
            if (!Existe(seguro.SeguroId))
            {
                return Insertar(seguro);
            }
            else
            {
                return Modificar(seguro);
            }
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Seguros.Any(s => s.SeguroId == id);
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

        private static bool Insertar(Seguros seguro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Seguros.Add(seguro);
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

        private static bool Modificar(Seguros seguro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(seguro).State = EntityState.Modified;
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
                var seguro = contexto.Seguros.Find(id);

                if (seguro != null)
                {
                    contexto.Seguros.Remove(seguro);
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

        public static Seguros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Seguros seguro;

            try
            {
                seguro = contexto.Seguros.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return seguro;
        }

        public static List<Seguros> GetList(Expression<Func<Seguros, bool>> criterio)
        {
            List<Seguros> lista = new List<Seguros>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Seguros.Where(criterio).ToList();
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

        public static List<Seguros> GetSeguros()
        {
            List<Seguros> lista = new List<Seguros>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Seguros.ToList();
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
