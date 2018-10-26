using HOI4_State_Editor.Data;
using HOI4_State_Editor.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Exporters
{
    class StateExporter
    {
        public static void ExportState(State state, bool saveToOutputFolder = false)
        {
            StringBuilder sb = new StringBuilder();
            //Console.WriteLine("State: " + state.NameOfFile);
            sb.AppendLine("state={");
            sb.AppendLine("\tid="+state.ID.ToString());
            sb.AppendLine("\tname=" + state.PlaceholderName);
            sb.AppendLine("\tmanpower=" + state.MainVariables["manpower"]);
            sb.AppendLine("\tstate_category=" + state.MainVariables["state_category"]);
            if (state.Resources.Count > 0)
            {
                sb.AppendLine("\tresources={");
                foreach(string res in state.Resources.Keys)
                {
                    sb.AppendLine("\t\t" + res+"="+state.Resources[res].ToString()+"\n");
                }
                sb.AppendLine("\t}");
            }
            
            sb.AppendLine();

            // History section
            sb.AppendLine("\thistory={");
            sb.AppendLine("\t\towner = "+state.Owner);
            foreach (string core in state.Cores)
            {
                sb.AppendLine("\t\tadd_core_of = " + core);
            }
            sb.AppendLine();

            // Victory Points
            foreach (int prov in state.VictoryPoints.Keys)
            {
                sb.AppendLine("\t\tvictory_points = {");
                sb.AppendLine("\t\t\t"+prov.ToString()+" "+state.VictoryPoints[prov].ToString());
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine();

            sb.AppendLine("\t\tbuildings = {");

            // Infrastructure comes first
            if (state.GetStateBuildings().ContainsKey("infrastructure"))
            {
                sb.AppendLine("\t\t\tinfrastructure = " + state.GetStateBuildings()["infrastructure"]);
            }

            // All other state buildings
            foreach(string building in state.GetStateBuildings().Keys)
            {
                if (building != "infrastructure")
                {
                    sb.AppendLine("\t\t\t"+building+" = " + state.GetStateBuildings()[building].ToString());
                }
            }

            // Province specific buildings
            foreach (int provId in state.GetProvinceBuildings().Keys)
            {
                sb.AppendLine("\t\t\t" + provId.ToString() + " = {");
                foreach (string provBuild in state.GetProvinceBuildings()[provId].Keys)
                {
                    sb.AppendLine("\t\t\t\t" + provBuild + " = " + state.GetProvinceBuildings()[provId][provBuild].ToString());
                }
                sb.AppendLine("\t\t\t}");
            }

            // End of buildings
            sb.AppendLine("\t\t}");
            
            // End of history
            sb.AppendLine("\t}");
            sb.AppendLine();

            // Provinces
            sb.AppendLine("\tprovinces={");
            sb.Append("\t\t");
            foreach (int prov in state.Provinces)
            {
                sb.Append(prov.ToString()+" ");
            }
            sb.AppendLine();
            sb.AppendLine("\t}");

            // End of state
            sb.Append("}");
            string outputFile = sb.ToString();
            string outputPath = saveToOutputFolder ? ModFileReader.StatesPath + "output/" : ModFileReader.StatesPath;

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            StreamWriter sw = new StreamWriter(outputPath + state.NameOfFile,false);
            sw.Write(outputFile);
            sw.Flush();
            sw.Close();
        }
    }
}
