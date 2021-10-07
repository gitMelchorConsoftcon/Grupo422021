using System.Collections.Generic;

namespace Grupo422021.Web1.Interfaces
{
    public  interface IRepositorioGenerico<T>
    {
        List<T> Listar();
        T Buscar(int id);
        T Guardar(T obj);
        T Modificar(int id ,T obj);
        T Borrar(int id);
    }
}
