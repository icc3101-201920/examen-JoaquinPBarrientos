using System;
using Examen.Interfaces;

namespace Examen.Embarcaciones
{
    public class Submarino : Embarcacion, SpecialAttack
    {
        public Submarino()
        {
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
