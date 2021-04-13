using System;
using Solid.Entities;
using System.Collections.Generic;
using Solid.ValueObjects;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Describimos las acciones
            Accion salidaDeArco = new AccionConBalon(
                new List<Posicion>{Posicion.Portero,Posicion.DefensaLateral}, 
                new int[2]{0,1}
            );
            Accion paredConPivote = new AccionConBalon(
                new List<Posicion>{Posicion.DefensaLateral,Posicion.Mediocapista}, 
                new int[3]{0,1,0}
            );
            Accion corridaPorBanda = new AccionConBalon(
                new List<Posicion>{Posicion.DefensaLateral}, 
                new int[1]{0}
            );
            Accion centrada = new AccionConBalon(
                new List<Posicion>{Posicion.DefensaLateral, Posicion.DelanteroCentral},
                new int[2]{1,0}
            );

            //Enlistamos las acciones
            var acciones = new List<Accion>{salidaDeArco, paredConPivote, corridaPorBanda, centrada};
            
            //Creamos el movimiento tactico
            var atacarBanda = new MovimientoOfensivo(1,"Ataque por la Banda", acciones);
            atacarBanda.finalizarConRemate();

            //Creamos la alineacion asociada a ese movimiento tactico
            Alineacion alineacionDefensiva = new Alineacion(1, "Defensiva",new Posicion[11]{
                Posicion.Portero,
                Posicion.DefensaCentral, Posicion.DefensaCentral, Posicion.DefensaLateral, Posicion.DefensaLateral, 
                Posicion.Mediocapista, Posicion.Mediocapista, Posicion.Mediocapista,Posicion.Mediocapista,Posicion.Mediocapista, 
                Posicion.DelanteroCentral
                });

            // visualizamos la alineacion
            Console.WriteLine($"La disposicion de la alineacion {alineacionDefensiva._nombre} es: {alineacionDefensiva._disposicion}\n");

            // añadimos un movimiento
            alineacionDefensiva.añadirMovimiento(atacarBanda);

            // describir movimientos de alineacion
            alineacionDefensiva.describirMovimientos();
        }
    }
}
