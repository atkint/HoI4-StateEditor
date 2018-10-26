using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class ProvinceBuilding
    {
        public string BuildingType;
        public int Value;

        public ProvinceBuilding(string buildingType, int value)
        {
            BuildingType = buildingType;
            Value = value;
        }
    }
}
