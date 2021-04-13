using System;
using System.Collections.Generic;

namespace Solid.ValueObjects
{
    class AccionConBalon: Accion
    {
        private int[] _recorridoBalon;
        public AccionConBalon(List<Posicion> posicionesProtagonistas, int[] recorridoBalon)
            :base(posicionesProtagonistas)
        {
            _recorridoBalon = recorridoBalon;
        }
        public override void describirSecuencia()
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