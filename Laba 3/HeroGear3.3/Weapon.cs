using System.Dynamic;

namespace HeroGear
{
    public class Weapon : CharacterGear
    {
        public Weapon(string GearName, int dmg) : base(GearName)
        {
            Dmg = dmg;
        }
        public int Dmg { get; set; }

        public override string GetGearFullInfo()
        {
            return $"Название {GearName} - {Dmg} урона";
        }
    }
}