using System;
using System.Collections.Generic;
using Examen.Embarcaciones;
using Examen.Enums;

namespace Examen
{
    public class Board
    {
        private Player boardPlayerid;
        private List<Embarcacion> boardPlayer;

        public Board(Player idPlayer)
        {
            BoardPlayerid = idPlayer;
            BoardPlayer= new List<Embarcacion>();
        }

        public Player BoardPlayerid
            {
                get => boardPlayerid;
                set => boardPlayerid = value;
            }
        public List<Embarcacion> BoardPlayer
        {
            get => boardPlayer;
            set => boardPlayer = value;
        }
        public Attack()
        {
            // En este metodo lo utilizaria para los handler , events , para cuando desde el metodo de cada embarcacion, ataque,
            // le avise a este metodo, que lo que hará es tratar de generar el ataque utilizando la lista, lamentablemene no me dio el tiempo.

        }
    }
}
