namespace HeroGear
{
    public class Character<T> where T : CharacterGear
    {
        public List<T> GearList = [];
        public void GearPrint()
        {
            GearList.ForEach(e =>
            {
                Console.WriteLine(e.GetGearFullInfo());
            }
            );
        }
    }
}