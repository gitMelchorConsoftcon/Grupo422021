using Grupo422021.Web1.Data;
using Grupo422021.Web1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grupo422021.Web1.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {

        private readonly DataContext _contexto;
        private readonly DbSet<T> Entidad;
        public RepositorioGenerico(DataContext contexto)
        {
            _contexto = contexto;
            Entidad = _contexto.Set<T>();
        }


        public List<T> Listar()
        {
            return Entidad.ToList();
        }
        public T Buscar(int id)
        {
            return Entidad.Find(id);
        }
        public T Guardar(T obj)
        {
            _contexto.Add(obj);
            _contexto.SaveChanges();
            return obj;
        }
        public T Modificar(int id, T obj)
        {
           // var modificar = Entidad.Find(id);

            //if (modificar!=null)
           // {
             //   modificar = obj;
                Entidad.Attach(obj);
                _contexto.Entry(obj).State = EntityState.Modified;
                _contexto.SaveChanges();
                return obj;
            //}

           // return null;
        }

        public T Borrar(int id)
        {

            var borrar = Entidad.Find(id);
            if (borrar!=null)
            {
                _contexto.Remove(borrar);
                _contexto.SaveChanges();
                return borrar;
            }

            return null;
           
        }

       

      

     

       
    }
}
