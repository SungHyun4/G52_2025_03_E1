using System;
using UnityEngine;

namespace packagePunto
{
    [Serializable]
    public class Punto2D
    {
        private double x;
        private double y;

        public Punto2D()
        {
        }

        public Punto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }
    }
}