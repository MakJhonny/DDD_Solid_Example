using System;
using System.Collections.Generic;

namespace Solid.ValueObjects
{
    abstract class Accion
    {
        protected List<Posicion> _posicionesActuantes;
        public Accion(List<Posicion> posicionesActuales){
            _posicionesActuantes = posicionesActuales;
        }
        public abstract void describirSecuencia();

    }
}