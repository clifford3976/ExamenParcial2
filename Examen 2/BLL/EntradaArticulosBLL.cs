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
    public class EntradaArticulosBLL
    {
        public static bool Guardar(EntradaArticulos entradaArticulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
           
            try
            {

                if (contexto.entradaArticulo.Add(entradaArticulo) != null)
                {
                    Articulos articulos = BLL.ArticulosBLL.Buscar(entradaArticulo.ArticuloId);
                    articulos.Inventario += entradaArticulo.Cantidad;
                    BLL.ArticulosBLL.Modificar(articulos);

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
                EntradaArticulos entradaArticulo = contexto.entradaArticulo.Find(id);

                if (entradaArticulo != null)
                {
                    Articulos articulos = BLL.ArticulosBLL.Buscar(entradaArticulo.ArticuloId);
                    articulos.Inventario -= entradaArticulo.Cantidad;
                    BLL.ArticulosBLL.Modificar(articulos);

                    contexto.Entry(entradaArticulo).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }



        public static bool Modificar(EntradaArticulos entradaArticulo)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                EntradaArticulos ant = BLL.EntradaArticulosBLL.Buscar(entradaArticulo.EntradaId);
                int resta;
                resta = entradaArticulo.Cantidad - ant.Cantidad;

                Articulos articulos = BLL.ArticulosBLL.Buscar(entradaArticulo.ArticuloId);
                articulos.Inventario += resta;
                BLL.ArticulosBLL.Modificar(articulos);

                contexto.Entry(entradaArticulo).State = EntityState.Modified;

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




        public static EntradaArticulos Buscar(int id)
        {

            EntradaArticulos entradaArticulo = new EntradaArticulos();
            Contexto contexto = new Contexto();

            try
            {
                entradaArticulo = contexto.entradaArticulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entradaArticulo;

        }



        public static List<EntradaArticulos> GetList(Expression<Func<EntradaArticulos, bool>> expression)
        {
            List<EntradaArticulos> entradaArticulo = new List<EntradaArticulos>();
            Contexto contexto = new Contexto();

            try
            {
                entradaArticulo = contexto.entradaArticulo.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return entradaArticulo;
        }


    }
}
