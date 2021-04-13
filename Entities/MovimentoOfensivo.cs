using System;
using Solid.ValueObjects;
using System.Collections.Generic;

namespace Solid.Entities
{
    class MovimientoOfensivo: MovimientoTactico
    {
        private int _cantidadPasos;
        private bool _finalizacionConRemate;
        public MovimientoOfensivo(int ID, string nombre, List<AccionConBalon> acciones)
            :base(ID,nombre, acciones)
        {
            _cantidadPasos = 0;
            _finalizacionConRemate = false;
        }
        public override void agregarAccion(AccionConBalon accion)
        {
            _acciones.Add(accion);
            _cantidadPasos++;
        }
        public override void describir()
        {
            Console.WriteLine($"El movimiento: {_nombre} consiste en:");
            foreach (var accion in _acciones)
            {
                accion.describirSecuenciaConBalon();
            }
            string mensajeFinal = (_finalizacionConRemate)?" con remate a porteria.":".";
            Console.WriteLine($"El movimiento termina{mensajeFinal}");
        }
        public void finalizarConRemate(){
            
            _finalizacionConRemate = true;
        }
    }
}