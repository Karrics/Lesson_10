using System;
using System.Collections.Generic;


namespace Tymakov_11_12
{
    internal class Creator
    {
        private static Dictionary<int, Building> buildingDictionary = new Dictionary<int, Building>();

        private Creator()
        {
        }

        public static Building CreateBuild(int buildingNumber, int height, int floors, int apartments, int entrances)
        {
            Building building = new Building(buildingNumber, height, floors, apartments, entrances);
            buildingDictionary.Add(buildingNumber, building);
            return building;
        }

        public static void RemoveBuilding(int buildingNumber)
        {
            buildingDictionary.Remove(buildingNumber);
        }
    }
}
