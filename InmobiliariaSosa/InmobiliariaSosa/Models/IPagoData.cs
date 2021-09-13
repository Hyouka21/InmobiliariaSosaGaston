using System.Collections.Generic;

namespace InmobiliariaSosa.Models
{
    public interface IPagoData : IData<Pago>
    {
        
        IList<Pago> obtenerTodoXId(int id);
    }
}