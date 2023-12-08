namespace HeroGear
{
    public abstract class CharacterGear
    {
        public string GearName { get; set; }
        public CharacterGear (string gearName)
        {
            GearName = gearName;
        }
        public abstract string GetGearFullInfo ();

    }
}
