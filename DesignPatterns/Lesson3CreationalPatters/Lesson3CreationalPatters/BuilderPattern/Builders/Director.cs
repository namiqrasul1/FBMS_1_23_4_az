using Lesson3CreationalPatters.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.BuilderPattern.Builders
{
    enum HouseType
    {
        IkiOtaqli,
        UchOtaqli,
        DordOtaqli
    }
    internal class Director
    {
        private IHouseBuilder _houseBuilder;

        public Director(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void ChangeBuilder(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public House Make(HouseType type)
        {
            
            var result =  type switch
            {
                HouseType.IkiOtaqli => _houseBuilder.BuildWindows(5).BuildRooms(2).BuildDoors(4).BuildRoof().GetHouse(),
                HouseType.UchOtaqli => _houseBuilder.BuildWindows(6).BuildRooms(3).BuildDoors(5).BuildRoof().GetHouse(),
                HouseType.DordOtaqli => _houseBuilder.BuildWindows(6).BuildRooms(4).BuildDoors(6).BuildRoof().GetHouse(),
                _ => throw new ArgumentException(),
            };
            _houseBuilder.Reset();
            return result; 
        }
    }
}
