﻿using System.Collections.Generic;

namespace InmobiliariaSosa.Models
{
    public interface IInmuebleData : IData<Inmueble>
    {

        IList<Inmueble> obtenerInmueblesDisponibles();
        IList<Inmueble> obtenerInmuebles(string desde, string hasta, int id);
        IList<Inmueble> obtenerXPropietario(int id);
    }
}