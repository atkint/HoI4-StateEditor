using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class Province
    {
        public bool IsWater;
        public int ID;

        public Province (int id, bool isWater)
        {
            ID = id;
            IsWater = isWater;
        }
    }
}
