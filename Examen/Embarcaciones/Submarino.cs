using System;
using Examen.Enums;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Submarino : Embarcacion, SpecialAttack
    {
        public Submarino(Orientation O, int DesiredX, int DesiredY)
        {
            ActualCentreX = DesiredX;
            ActualCentreY = DesiredY;
            Orientation = O;
            Lives = 3;
        }

        public void Attack()
        {
        }

        public void Move()
        {
        }

        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}
