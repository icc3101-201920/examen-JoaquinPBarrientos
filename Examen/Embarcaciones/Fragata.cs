using System;
using Examen.Enums;

namespace Examen.Embarcaciones
{
    public class Fragata : Embarcacion
    {

        public Fragata(Orientation O,int DesiredX,int DesiredY)
        {
            ActualCentreX = DesiredX;
            ActualCentreY = DesiredY;
            Orientation = O;
            Lives = 2;
        }

        public void Attack()
        {

        }

        public void Move(string X, string Y)
        { 
        }

    }
}
