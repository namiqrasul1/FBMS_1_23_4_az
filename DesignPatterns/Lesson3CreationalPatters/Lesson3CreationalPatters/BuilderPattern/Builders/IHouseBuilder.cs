﻿using Lesson3CreationalPatters.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.BuilderPattern.Builders
{
    internal interface IHouseBuilder
    {
        House House { get; }
        IHouseBuilder BuildWalls(int count);
        IHouseBuilder BuildDoors(int count);
        IHouseBuilder BuildWindows(int count);
        IHouseBuilder BuildRooms(int count);
        IHouseBuilder BuildGarden();
        IHouseBuilder BuildGarrage();
        IHouseBuilder BuildPool();
        IHouseBuilder BuildRoof();
        IHouseBuilder Reset();

        House GetHouse();
    }
}
