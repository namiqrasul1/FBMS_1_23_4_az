﻿using Lesson3CreationalPatters.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.BuilderPattern.Builders
{
    internal class StoneHouseBuilder : IHouseBuilder
    {
        public House House { get; set; } = new() { Name = "Stone House" };

        public IHouseBuilder BuildDoors(int count)
        {
            House.Doors = count;
            return this;
        }

        public IHouseBuilder BuildGarden()
        {
            House.HasGarden = true;
            return this;
        }

        public IHouseBuilder BuildGarrage()
        {
            House.HasGarrage = true;
            return this;
        }

        public IHouseBuilder BuildPool()
        {
            House.HasPool = true;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            House.HasRoof = true;
            return this;
        }

        public IHouseBuilder BuildRooms(int count)
        {
            House.Rooms = count;
            return this;
        }

        public IHouseBuilder BuildWalls(int count)
        {
            House.Walls = count;
            return this;
        }

        public IHouseBuilder BuildWindows(int count)
        {
            House.Windows = count;
            return this;
        }

        public House GetHouse() => House;

        public IHouseBuilder Reset()
        {
            House = new House { Name = "Stone House" };
            return this;
        }
    }
}
