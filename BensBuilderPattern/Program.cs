using System;

namespace BensBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftDrinkBuilder softDrinkBuilder;

            Shop shop = new Shop();

            softDrinkBuilder = new FantaBuilder();
            shop.Construct(softDrinkBuilder);
            softDrinkBuilder.SoftDrink.Serve();

            softDrinkBuilder = new TangoBuilder();
            shop.Construct(softDrinkBuilder);
            softDrinkBuilder.SoftDrink.Serve();

            Console.ReadKey();
        }
    }
}
