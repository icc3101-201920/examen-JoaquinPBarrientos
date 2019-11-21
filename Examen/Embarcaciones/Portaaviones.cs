using System;
using Examen.Enums;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Portaaviones : Embarcacion, SpecialAttack
    {
        public Portaaviones(Orientation O, int DesiredX, int DesiredY, Player idPlayer)
        {   
            Lives = 5;
            ActualCentreX = DesiredX;
            ActualCentreY = DesiredY;
            Orientation = O;
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
