using System;
using Examen.Enums;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Reparador
    {
        public class Portaaviones : Embarcacion, SpecialAttack
        {
            public Portaaviones(Orientation O, int DesiredX, int DesiredY)
            {
                ActualCentreX = DesiredX;
                ActualCentreY = DesiredY;
                Orientation = O;
                Lives = 4;
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
}
