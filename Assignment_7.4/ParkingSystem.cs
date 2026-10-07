using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7._4
{
    public enum Type  { Big = 1, Medium, Small }
    internal class ParkingSystem
    {
        Dictionary<Type, int> Cars = new Dictionary<Type, int> {
            {Type.Big, 0 },
            {Type.Medium, 0 },
            {Type.Small, 0 }
        };

        public ParkingSystem(int big, int medium, int small) 
        {
            Cars[Type.Big] = big;
            Cars[Type.Medium] = medium;
            Cars[Type.Small] = small;
        }

        public bool AddCar(int carType)
        {
            if (Cars.ContainsKey((Type) carType) && Cars[(Type) carType] > 0)
            {
                Cars[(Type)carType]--;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Big Car Lot: {Cars[Type.Big]}\n" +
                $"Medium Car Lot: {Cars[Type.Medium]}\n" +
                $"Small Car Lot: {Cars[Type.Small]}\n";
        }
    }
}
