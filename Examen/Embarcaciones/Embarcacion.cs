using System;
using Examen.Enums;

namespace Examen.Embarcaciones
{
    public abstract class Embarcacion
    {

        private int size;
        private int actualCentreX;
        private int actualCentreY;
        private int lives;
        private Orientation orientation;

        public void Attack() { }

        public void Move() { }

        public int Size
        {
            get => size;
            set => size = value; 
        }

        public int ActualCentreX
        {
            get => actualCentreX;
            set => actualCentreX = value;
        }

        public int ActualCentreY
        {
            get => actualCentreY;
            set => actualCentreY = value;
        }

        public int Lives
        {
            get => lives;
            set => lives = value;
        }

        public Orientation Orientation
        {
            get => orientation;
            set =>  orientation = value;
        }



    }
}
