using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    static class StateChangesTracker
    {
        public static State SelectedState = null;

        public static Dictionary<string, int> NewBuildingValues = new Dictionary<string, int>();
        public static List<string> NewCores = new List<string>();
        public static string NewOwner;

        public static void Reset()
        {
            NewBuildingValues = new Dictionary<string, int>();
            NewCores = new List<string>();
            NewOwner = SelectedState.Owner;
        }
    }
}
