using System.Collections.Generic;

namespace InmobiliariaSosa.Models
{
    public interface IUsuarioData : IData<Usuario>
    {
     
        Usuario ObtenerPorEmail(string email);
       
      
    }
}