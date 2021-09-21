using System.Collections.Generic;

namespace InmobiliariaSosa.Models
{
    public interface IContratoData : IData<Contrato>
    {
        IList<Contrato> obtenerXInmueble(int id);
        IList<Contrato> obtenerXFecha(string desde, string hasta);
    }
}