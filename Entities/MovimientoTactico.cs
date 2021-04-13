using System;
using System.Collections.Generic;
using Solid.ValueObjects;

namespace Solid.Entities
{
    abstract class MovimientoTactico
    {
        protected int _ID;
        protected string _nombre;
        protected List<Accion> _acciones;
        public MovimientoTactico(int ID, string nombre, List<Accion> acciones){
            _ID = ID;
            _nombre = nombre;
            _acciones = acciones;
        }
        public abstract void agregarAccion(Accion accion);
        public abstract void describir();
    }
}