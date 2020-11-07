using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Klassen
{
    public class Eggs
    {
        int quantity;// List<Egg> eggs;

        public Eggs()
        {
            //  this.eggs = new List<Egg>();
        }

        public void FryEggs(int quantity)
        {

            this.quantity += quantity;
        }

        public int Length
        {
            get { return this.quantity; }
        }


        public string Print()
        {
            return this.quantity + " eggs";
        }

    }
}
