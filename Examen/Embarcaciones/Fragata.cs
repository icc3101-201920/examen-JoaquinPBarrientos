using System;
namespace Examen.Embarcaciones
{
    public class Fragata : Embarcacion
    {

        public Fragata()
        {
            Lives = 4;
        }

        public void Attack()
        {
        }

        public void Move(string X, string Y)
        {
            const int maxMovePosition = 2;

            int desiredPositionX = Int32.Parse(X);
            int desiredPositionY = Int32.Parse(Y);
            int ActualPositionX = ActualCentreX;
            int ActualPositionY = ActualCentreY;


        }

    }
}
