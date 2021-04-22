// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02C_2

using System;

namespace _02c_2_C00170400
{
    class Dirt
    {
        private double gramsOfSand;
        private double gramsOfClay;

        public Dirt()
        {
            this.gramsOfSand = 1.0;
            this.gramsOfClay = 1.0;
        }

        public Dirt(double s, double c)
        {
            if (s >= 0)
                this.gramsOfSand = s;
            if (c >= 0)
                this.gramsOfClay = c;
        }

        public void IncreaseSand()
        {
            this.gramsOfSand += 1;
        }

        public void DecreaseSand()
        {
            this.gramsOfSand -= 1;
        }

        public void IncreaseClay()
        {
            this.gramsOfClay += 1;
        }

        public void DecreaseClay()
        {
            this.gramsOfClay -= 1;
        }

        public double GetSand()
        {
            return gramsOfSand;
        }

        public double GetClay()
        {
            return gramsOfClay;
        }


    }
}