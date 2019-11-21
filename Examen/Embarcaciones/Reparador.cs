using System;
using Examen.Enums;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
        public class Reparador : Embarcacion, SpecialAttack
        {
            public Reparador(Orientation O, int DesiredX, int DesiredY,Player idPlayer)
            {
                ActualCentreX = DesiredX;
                ActualCentreY = DesiredY;
                Orientation = O;
                Lives = 4;
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

