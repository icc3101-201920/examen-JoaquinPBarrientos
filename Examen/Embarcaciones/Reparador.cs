using System;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Reparador
    {
        public class Portaaviones : Embarcacion, SpecialAttack
        {
            public Portaaviones()
            {
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
