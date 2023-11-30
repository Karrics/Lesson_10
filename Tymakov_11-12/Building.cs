using System;


namespace Tymakov_11_12
{
    internal class Building
    {
        private int buildingNumber;
        private int height;
        private int floors;
        private int apartments;
        private int entrances;

        public Building(int buildingNumber, int height, int floors, int apartments, int entrances)
        {
            this.buildingNumber = buildingNumber;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        public int GetBuildingNumber()
        {
            return buildingNumber;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetFloors()
        {
            return floors;
        }

        public int GetApartments()
        {
            return apartments;
        }

        public int GetEntrances()
        {
            return entrances;
        }

        public double CalculateFloorHeight()
        {
            return (double)height / floors;
        }

        public double CalculateApartmentsPerEntrance()
        {
            return (double)apartments / entrances;
        }

        public double CalculateApartmentsPerFloor()
        {
            return (double)apartments / floors;
        }
    }
}
