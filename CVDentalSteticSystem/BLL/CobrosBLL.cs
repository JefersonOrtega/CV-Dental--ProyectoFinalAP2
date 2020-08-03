using CVDentalSteticSystem.DAL;
using CVDentalSteticSystem.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.DropDowns;
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

        public static bool Insertar(Cobros cobros)
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

        public static bool Modificar(Cobros cobros)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            var anterior = CobrosBLL.Buscar(cobros.CobroId);
            try
            {
                //Pacientes paciente = PacientesBLL.Buscar(cobros.PacienteId);
                //paciente.Balance += anterior.Monto; //todo: Revisar funcionamiento
                //paciente.Balance -= cobros.Monto;

                foreach (var item in anterior.CobroDetalles)
                {
                    if (!cobros.CobroDetalles.Exists(c => c.CobroDetallesId == item.CobroDetallesId))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in cobros.CobroDetalles)
                {
                    if (item.CobroDetallesId == 0)
                        contexto.Entry(item).State = EntityState.Added;
                    else
                        contexto.Entry(item).State = EntityState.Modified;
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

        //public static void PagarMonto(int id, decimal abono)
        //{
        //    Contexto contexto = new Contexto();
        //    var paciente = PacientesBLL.Buscar(id);

        //    try
        //    {
        //        if (paciente != null)
        //        {
        //            paciente.Balance -= abono;
        //            abono -= paciente.Balance;
        //            PacientesBLL.Guardar(paciente);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        contexto.Dispose();
        //    }
        //}
    }
}

