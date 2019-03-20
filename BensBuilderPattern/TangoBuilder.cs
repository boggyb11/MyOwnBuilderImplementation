
namespace BensBuilderPattern
{
    class TangoBuilder : SoftDrinkBuilder
    {
        public TangoBuilder()
        {
            SoftDrink = new SoftDrink("Tango");
        }

        public override void BuildDrink()
        {
            softDrink.sugarLevel = 25.0f;
        }
    }
}
