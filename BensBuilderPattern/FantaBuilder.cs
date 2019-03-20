
namespace BensBuilderPattern
{
    class FantaBuilder : SoftDrinkBuilder
    {
        public FantaBuilder()
        {
            SoftDrink = new SoftDrink("Fanta");
        }

        public override void BuildDrink()
        {
            softDrink.sugarLevel = 50.0f;
        }
    }
}
