using System.Collections.Generic;

namespace InmobiliariaSosa.Models
{
    public interface IInmuebleData : IData<Inmueble>
    {
     
    
        IList<Inmueble> obtenerInmuebles(string desde, string hasta, int id);
     
    }
}