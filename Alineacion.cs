using System;
using System.Collections.Generic;
using Solid.ValueObjects;
using Solid.Entities;

namespace Solid
{
    enum Posicion{
        Portero=1,
        DefensaCentral = 5,
        DefensaLateral = 3,
        Mediocapista = 8,
        DelanteroLateral = 11,
        DelanteroCentral = 9

    }
    class Alineacion
    {
        private int _ID;
        public string _nombre;
        private Posicion[] _posiciones;
        public string _disposicion;
        private List<MovimientoTactico> _movimientos;
        private void crearDisposicion()
        {
            int zonaDefensa=0, zonaMedio=0, zonaDelantera=0;
            foreach(var posicion in _posiciones)
            {
                zonaDefensa += (1 < (int)posicion && (int)posicion <= 5)? 1: 0;
                zonaMedio += (5 < (int)posicion && (int)posicion <= 8)? 1: 0;
                zonaDelantera += ((int)posicion > 8)? 1: 0;
            }
            _disposicion = $"1 - {zonaDefensa} - {zonaMedio} - {zonaDelantera}";
        }
        public Alineacion(int ID, string nombre, Posicion[] posiciones)
        {
            _ID = ID;
            _nombre = nombre;
            _posiciones = posiciones;
            crearDisposicion();
            _movimientos = new List<MovimientoTactico>();
        }
        public void añadirMovimiento(MovimientoTactico movimiento)
        {
            _movimientos.Add(movimiento);
        }
        public void describirMovimientos()
        {
            Console.WriteLine($"MOVIMIENTOS\n");
            foreach(var movimiento in _movimientos){
                movimiento.describir();
            }
        }
    }
}