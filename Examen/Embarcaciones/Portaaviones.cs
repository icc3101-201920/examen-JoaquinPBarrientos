using System;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Portaaviones : Embarcacion, SpecialAttack
    {
        public Portaaviones()
        {
            Lives = 5;
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
