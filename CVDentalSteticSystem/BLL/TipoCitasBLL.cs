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
    public class TipoCitasBLL
    {
        public static bool Guardar(TipoCitas tipoCita)
        {
            if (!Existe(tipoCita.TipoCitaId))
            {
                return Insertar(tipoCita);
            }
            else
            {
                return Modificar(tipoCita);
            }
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.TipoCitas.Any(t => t.TipoCitaId == id);
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

        public static bool Insertar(TipoCitas tipoCita)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.TipoCitas.Add(tipoCita);
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

        public static bool Modificar(TipoCitas tipoCita)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tipoCita).State = EntityState.Modified;
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
                var tipoCita = contexto.TipoCitas.Find(id);

                if (tipoCita != null)
                {
                    contexto.TipoCitas.Remove(tipoCita);
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

        public static TipoCitas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoCitas tipoCita;

            try
            {
                tipoCita = contexto.TipoCitas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tipoCita;
        }

        public static List<TipoCitas> GetList(Expression<Func<TipoCitas, bool>> criterio)
        {
            List<TipoCitas> lista = new List<TipoCitas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TipoCitas.Where(criterio).ToList();
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

        public static List<TipoCitas> GetTipoCitas()
        {
            List<TipoCitas> lista = new List<TipoCitas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoCitas.ToList();
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
