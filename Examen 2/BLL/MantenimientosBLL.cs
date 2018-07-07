using Examen_2.DAL;
using Examen_2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Examen_2.BLL
{
   public class MantenimientosBLL
    {
        public static bool Guardar(Mantenimientos mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


            Vehiculos vehiculo = new Vehiculos();
            try
            {
                if (contexto.mantenimiento.Add(mantenimiento) != null)
                {

                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulo.Find(item.ArticulosId).Inventario -= item.Cantidad;
                    }


                    contexto.vehiculo.Find(mantenimiento.VehiculoId).TotalMantenimiento += mantenimiento.Total;

                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Mantenimientos mantenimiento = contexto.mantenimiento.Find(id);


                if (mantenimiento != null)
                {
                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulo.Find(item.ArticulosId).Inventario += item.Cantidad;

                    }

                    mantenimiento.Detalle.Count();
                    contexto.mantenimiento.Remove(mantenimiento);
                }




                if (contexto.SaveChanges() > 0)
                {

                    paso = true;
                }
                contexto.Dispose();


            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }




        public static Mantenimientos Buscar(int id)
        {
            Mantenimientos mantenimiento = new Mantenimientos();
            Contexto contexto = new Contexto();

            try
            {
                mantenimiento = contexto.mantenimiento.Find(id);
                if (mantenimiento != null)
                {
                    mantenimiento.Detalle.Count();

                    foreach (var item in mantenimiento.Detalle)
                    {

                        string s = item.Articulos.Descripcion;
                    }

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return mantenimiento;
        }


        public static bool Modificar(Mantenimientos mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var Mantenimiento = BLL.MantenimientosBLL.Buscar(mantenimiento.MantenimientoId);


                if (mantenimiento != null)
                {


                    foreach (var item in mantenimiento.Detalle)
                    {

                        contexto.articulo.Find(item.ArticulosId).Inventario += item.Cantidad;



                        if (!mantenimiento.Detalle.ToList().Exists(v => v.Id == item.Id))
                        {
                            contexto.entradaArticulo.Find(item.ArticulosId).Cantidad -= item.Cantidad;

                            item.Articulo = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }




                    }


                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulo.Find(item.ArticulosId).Inventario -= item.Cantidad;

                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }

                    contexto.Entry(mantenimiento).State = EntityState.Modified;
                }



                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static List<Mantenimientos> GetList(Expression<Func<Mantenimientos, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Mantenimientos> mantenimiento = new List<Mantenimientos>();

            try
            {
                mantenimiento = contexto.mantenimiento.Where(expression).ToList();

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return mantenimiento;

        }

        public static decimal CalcularImporte(decimal precio, int cantidad)
        {
            return Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
        }

        public static decimal CalcularITBIS(decimal subtotal)
        {
            return Convert.ToDecimal(subtotal) * Convert.ToDecimal(0.18);
        }

        public static decimal Total(decimal subtotal, decimal itbis)
        {
            return Convert.ToDecimal(subtotal) + Convert.ToDecimal(itbis);
        }

    }
}
