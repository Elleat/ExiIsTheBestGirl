using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Units
{
    public abstract class Units
    {
        public int Speed { get; set; }
        public string MainWeapon { get; set}
    }
    public class Troop : Infantry
    {
        private List<Infantry> InfantryList = new List<Infantry>();
        public void addUnit(Infantry infantry)
        {
            InfantryList.Add(infantry);
        }
        public void removeUnit(Infantry infantry)
        {
            InfantryList.Remove(infantry);
        }

    }
    public class Infantry : Units
    {
        public int Health { get; set; }
    }
    public class Infantryman : Infantry
    {
    }
    public class MachineGunTeam : Infantry
    {
        public string PersonalWeapon { get; set; }
    }

    public class Vehicle : Machines
    private List<Machines> VehicleList = mew List<Vehicle>();
    public void addUnit(Vehicle vehicle)
    {
        VehicleList.Add(vehicle);
    }
    public void removeUnit(Vehicle vehicle)
    {
        VehicleList.Remove(Vehicle vehicle);
    }
    public class Machines : Units
    {
        public int FuelCapacity { get; set; }
    }
    public class Tank : Machines
    {
        public int SeconderyWeapon { get; set; }
    }
    public class Fighter : Machines
    {
        public int DetectionRadius { get; set; }
    }
    public class Helicopter : Machines
    {
        public int DetectionRadius { get; set; }
    }
    public class artillery : Machines
    {
        public int FireRange { get; set; }
    }
}