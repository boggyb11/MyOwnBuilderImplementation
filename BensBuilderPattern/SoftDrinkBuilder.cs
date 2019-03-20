
namespace BensBuilderPattern
{
    abstract class SoftDrinkBuilder
    {
        protected SoftDrink softDrink;

        public SoftDrink SoftDrink
        {
            get { return softDrink; }
            set { softDrink = value; }
        }

        public abstract void BuildDrink();
    }
}
