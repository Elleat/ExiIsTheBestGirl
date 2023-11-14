using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BkastRadius
{
    public abstract class Unit 
    {
        public float Health {get; set;}
        public float ExpDistance {get; set;}
        public Unit(float Health, float ExpDistance)
        {
            this.Health = Health;
            this.ExpDistance = ExpDistance;
        }
        public abstract float RemHealth(float Distance, float ExpDistance);
    }
    public class infantryman : Unit
    {
        public infantryman (float Health, float ExpDistance) : base(Health, ExpDistance) 
        {

        }
        public override float RemHealth(float Distance, float ExpPower)
        {
            return this.Health - (ExpPower / Distance);
        }

    }
    public class Tank : Unit
    {
        public float Armor {get; set;}
        public Tank(float Health, float Armor, float ExpDistance) : base(Health, ExpDistance)
        {
            this.Armor = Armor;
        }
        public override float RemHealth (float Distance, float ExpPower)
        {
            return this.Health - ((ExpPower / Distance) * (1 - (this.Armor * (float)0.01)));
        }
    }
    public class UnitList : List<Unit>
    {
    public void Exp(float ExpPower)
        {
        foreach (var element in this)
            {
            element.health = element.RemHealth(element.ExpDistance, ExpPower);
            if (element.Health <= 0) {Console.WriteLine($"Юнит {element.GetType().Name} уничтожен в {element.DistanceToExplosion} от места взрыва"); }; 
            }
        }
    }
        class Program
        {
            static void Main(string [] args)
            {
                var List = new UnitList
                {
                    new Tank(25,0,0),
                    new Tank(25,50,1),
                    new Tank(25,100,1000),
                    new infantryman(25,0),
                    new infantryman(1000,1),
                    new infantryman(0,1000),
                };
                List.Exp (1000);
            }
        }
}