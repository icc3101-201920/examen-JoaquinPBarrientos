using System;
using Examen.Enums;

namespace Examen.Embarcaciones
{
    public abstract class Embarcacion
    {

        private int actualCentreX;
        private int actualCentreY;
        private int lives;
        private Orientation orientation;
        private int idOnBoard;

        public void Attack() { }

        public void Move() { }


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

        public int IdOnBoard
        {
            get => idOnBoard;
            set => idOnBoard = value;
        }

    }
}
