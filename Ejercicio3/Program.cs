using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos =
                new List<Equipo>();

            Equipo yaquis = new Equipo("Yaquis");
            yaquis.Entrenador = "Pedro";
            yaquis.CiudadOrigen = "Ciudad Obregon";

            yaquis.Jugadores.Add(
                new Jugador("Jugador 1", 5));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 2", 11));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 3", 2));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 4", 8));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 5", 31));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 6", 64));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 7", 28));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 8", 67));
            yaquis.Jugadores.Add(
                new Jugador("Jugador 9", 54));


            Equipo aguilas = new Equipo("Aguilas");
            aguilas.Entrenador = "Pedro";
            aguilas.CiudadOrigen = "Mexicali";

            aguilas.Jugadores.Add(
                new Jugador("Jugador 10", 25));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 11", 69));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 12", 18));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 13", 33));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 14", 66));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 15", 1));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 16", 57));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 17", 98));
            aguilas.Jugadores.Add(
                new Jugador("Jugador 18", 6));


            equipos.Add(yaquis);
            equipos.Add(aguilas);



            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" + equipo.Nombre + " de " + equipo.CiudadOrigen);


                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("*" + jugador.Nombre + " de " + jugador.Numero);
                }
            }

            Console.Read();

        }
    }
}
