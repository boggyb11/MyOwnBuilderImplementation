using System;

namespace BensBuilderPattern
{
    class SoftDrink
    {
        private readonly string _name;
        public float sugarLevel;

        public SoftDrink(string name)
        {
            _name = name;
        }

        public void Serve()
        {
            Console.WriteLine($"Serving {_name} With sugar level: {sugarLevel}");
        }


    }
}
