namespace HeroGear
{
    public class Armor : CharacterGear
    {
        public Armor(string GearName, int ac) : base(GearName)
        {
            AC = ac;
        }
        public int AC { get; set; }
        public override string GetGearFullInfo()
        {
            return $"Название {GearName} - класс доспеха {AC}";
        }
    }
}