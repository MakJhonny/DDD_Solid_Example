using System;
using System.Collections.Generic;

namespace Solid.ValueObjects
{
    class Pase: Accion, AccionConBalon
    {
        private int[] _recorridoBalon;
        private List<Posicion> _posicionesActuantes;
        public Pase(List<Posicion> posicionesProtagonistas, int[] recorridoBalon)
        {
            _recorridoBalon = recorridoBalon;
            _posicionesActuantes = posicionesProtagonistas;
        }
        public void describirProtagonistas()
        {
            Console.Write("Las Posiciones que participan en este accion son: ");
            foreach(var posicion in _posicionesActuantes)
            {
                Console.Write($"{posicion} ");
            }
            Console.WriteLine();
        }
        public void describirSecuenciaConBalon()
        {
            var primerActuante = _posicionesActuantes[_recorridoBalon[0]];
            if(_recorridoBalon.Length == 1){
                Console.WriteLine($"{primerActuante} corre con el balon.");
            }
            for(int i=1; i<_recorridoBalon.Length; i++)
            {
                Console.WriteLine($"{primerActuante} se la pasa a {_posicionesActuantes[_recorridoBalon[i]]}...");
                primerActuante = _posicionesActuantes[_recorridoBalon[i]];
            }
        }
    }
}