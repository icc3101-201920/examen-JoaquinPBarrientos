using System;
using Examen.Embarcaciones;
using Examen.Enums;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BATTLESHIP");

            //P1 tiene un tablero, y cada una de las embarcaciones
            Board BoardP1 = new Board(Player.P1);
            Portaaviones PaP1 = new Portaaviones(Orientation.Horizontal, 2, 6, Player.P1);
            Fragata FP1 = new Fragata(Orientation.Vertical, 2, 8, Player.P1);
            Submarino SP1 = new Submarino(Orientation.Vertical, 5, 3, Player.P1);
            Reparador RP1 = new Reparador(Orientation.Horizontal, 3, 8, Player.P1);
            Radar RaP1 = new Radar(Orientation.Horizontal, 8, 2, Player.P1);
            // P2 tambien las tiene
            Board BoardP2 = new Board(Player.P2);
            Portaaviones PaP2 = new Portaaviones(Orientation.Horizontal, 2, 6, Player.P2);
            Fragata FP2 = new Fragata(Orientation.Vertical, 2, 8, Player.P2);
            Submarino SP2 = new Submarino(Orientation.Vertical, 5, 3, Player.P2);
            Reparador RP2 = new Reparador(Orientation.Horizontal, 3, 8, Player.P2);
            Radar RaP2 = new Radar(Orientation.Horizontal, 8, 2, Player.P2);

        }
    }
}
