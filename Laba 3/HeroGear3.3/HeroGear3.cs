namespace HeroGear
{
    static class HeroGear3
    {
        public static void Main(string[] args)
        {
            Character<CharacterGear> character = new Character<CharacterGear>()
            {
                GearList = new List<CharacterGear>()
                {
                    new Armor("Studded Leather Armor", 12),
                    new Weapon("Long Sword",5),
                }
            };
            character.GearPrint();
        }
    }
}
