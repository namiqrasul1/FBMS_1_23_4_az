using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.BuilderPattern.Models
{
    internal class House
    {
        //public House(string name, int walls, int windows, int rooms, int doors, bool hasGarden, bool hasGarrage, bool hasRoof, bool hasPool)
        //{
        //    Name = name;
        //    Walls = walls;
        //    Windows = windows;
        //    Rooms = rooms;
        //    Doors = doors;
        //    HasGarden = hasGarden;
        //    HasGarrage = hasGarrage;
        //    HasRoof = hasRoof;
        //    HasPool = hasPool;
        //}

        public string Name { get; set; }
        public int Walls { get; set; }
        public int Windows { get; set; }
        public int Rooms { get; set; }
        public int Doors { get; set; }
        public bool HasGarden { get; set; }
        public bool HasGarrage { get; set; }
        public bool HasRoof { get; set; }
        public bool HasPool { get; set; }

        public override string ToString()
        {
            return
                $@"Name: {Name}
Walls: {Walls}
Doors: {Doors}
Windows: {Windows}
Rooms: {Rooms}
HasGarden: {HasGarden}
HasGarrage: {HasGarrage}
HasRoof: {HasRoof}
HasPool: {HasPool}";
        }
    }
}
