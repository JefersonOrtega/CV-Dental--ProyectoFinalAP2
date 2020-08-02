using CVDentalSteticSystem.DAL;
using CVDentalSteticSystem.Models;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.BLL
{
    public class TiposProcedimientosBLL
    {
        public static bool Guardar(TiposProcedimientos tipoProcedimiento)
        {
            if (!Existe(tipoProcedimiento.TipoProcedimientoId))
                return Insertar(tipoProcedimiento);
            else
                return Modificar(tipoProcedimiento);
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.TiposProcedimientos.Any(e =>e.TipoProcedimientoId ==id);
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

        public static bool Insertar(TiposProcedimientos tipoProcedimiento)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.TiposProcedimientos.Add(tipoProcedimiento);
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

        public static bool Modificar(TiposProcedimientos tipoProcedimiento)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(tipoProcedimiento).State = EntityState.Modified;
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
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var tipoProcedimiento = contexto.TiposProcedimientos.Find(id);

                if (tipoProcedimiento != null)
                {
                    contexto.TiposProcedimientos.Remove(tipoProcedimiento);
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

        public static TiposProcedimientos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TiposProcedimientos tipoProcedimiento;

            try
            {
                tipoProcedimiento = contexto.TiposProcedimientos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipoProcedimiento;
        }

        public static List<TiposProcedimientos> GetList(Expression<Func<TiposProcedimientos, bool>> criterio)
        {
            List<TiposProcedimientos> lista = new List<TiposProcedimientos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposProcedimientos.Where(criterio).ToList();
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

        public static List<TiposProcedimientos> GetTiposProcedimientos()
        {
            List<TiposProcedimientos> lista = new List<TiposProcedimientos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposProcedimientos.ToList();
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
