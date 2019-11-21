using System;
using Examen.Enums;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Submarino : Embarcacion, SpecialAttack
    {
        public Submarino(Orientation O, int DesiredX, int DesiredY,Player idPlayer)
        {
            ActualCentreX = DesiredX;
            ActualCentreY = DesiredY;
            Orientation = O;
            Lives = 3;
            IdPlayer = idPlayer;
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
