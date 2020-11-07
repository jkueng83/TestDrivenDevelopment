using System;
using System.Collections.Generic;
using System.Text;



namespace TestDrivenDevelopment.Klassen
{
    public class Breakfast
    {

        public static Coffee PourCoffee()
        {
            return new Coffee();//   Console.WriteLine("Pour Coffee");
        }

        public static Bacon FryBacon(int quantity)
        {
            return new Bacon(quantity);
        }

        public static Bacon EatBacon(ref Bacon bacon, int quantityEat)
        {
            bacon.EatBacon(quantityEat);
            return bacon;
        }

        public static Eggs FryEggs(int quantity)
        {
            Eggs eggs = new Eggs();
            eggs.FryEggs(quantity);
            return eggs;
        }

        public static Toast[] ToastBread(int quantity)
        {
            Toast[] toasts = new Toast[quantity];

            for (int i = 0; i < quantity; i++)
            {
                toasts[i] = new Toast();
            }
            
            return toasts;
        }

        public static void ApplyButter(Toast toast) => toast.ApplyButter();
        public static void ApplyJam(Toast toast) => toast.ApplyJam();

    }
}
