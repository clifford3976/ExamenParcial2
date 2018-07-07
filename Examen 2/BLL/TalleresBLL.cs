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
    public class TalleresBLL
    {
        public static bool Guardar(Talleres taller)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.taller.Add(taller) != null)
                {
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
                Talleres taller = contexto.taller.Find(id);

                if (taller != null)
                {
                    contexto.Entry(taller).State = EntityState.Deleted;
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



        public static bool Modificar(Talleres taller)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(taller).State = EntityState.Modified;

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



        public static Talleres Buscar(int id)
        {

            Talleres taller = new Talleres();
            Contexto contexto = new Contexto();

            try
            {
                taller = contexto.taller.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return taller;

        }



        public static List<Talleres> GetList(Expression<Func<Talleres, bool>> expression)
        {
            List<Talleres> taller = new List<Talleres>();
            Contexto contexto = new Contexto();

            try
            {
                taller = contexto.taller.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return taller;
        }
    }
}
