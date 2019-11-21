using System;
using Examen.Enums;

namespace Examen.Embarcaciones
{
    public class Fragata : Embarcacion
    {

        public Fragata(Orientation O,int DesiredX,int DesiredY,Player idPlayer)
        {
            ActualCentreX = DesiredX;
            ActualCentreY = DesiredY;
            Orientation = O;
            Lives = 2;
            IdPlayer = idPlayer;
        }

        public void Attack()
        {

        }

        public void Move(string X, string Y)
        { 
        }

    }
}
