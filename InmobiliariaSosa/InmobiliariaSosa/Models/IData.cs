using System.Collections.Generic;

namespace InmobiliariaSosa.Models
{
    public interface IData<T>
    {
        int alta(T i);
        int Baja(int id);
        int Modificacion(T e);
        T ObtenerPorId(int id);
        IList<T> obtenerTodo();
    }
}