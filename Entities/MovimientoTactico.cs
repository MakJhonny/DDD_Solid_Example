using System;
using System.Collections.Generic;
using Solid.ValueObjects;

namespace Solid.Entities
{
    abstract class MovimientoTactico
    {
        protected int _ID;
        protected string _nombre;
        protected List<AccionConBalon> _acciones;
        public MovimientoTactico(int ID, string nombre, List<AccionConBalon> acciones){
            _ID = ID;
            _nombre = nombre;
            _acciones = acciones;
        }
        public abstract void agregarAccion(AccionConBalon accion);
        public abstract void describir();
    }
}