using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class StateHistoryGroup
    {
        public BuildingsGroup Buildings;
        public string Owner;
        public Dictionary<int, int> VictoryPoints;
        public List<string> Cores;
        public Dictionary<string, StateHistoryGroup> BookmarkHistories;

        public StateHistoryGroup()
        {
            VictoryPoints = new Dictionary<int, int>();
            Cores = new List<string>();
            BookmarkHistories = new Dictionary<string, StateHistoryGroup>();
        }

        string readAndRemoveDates(string fullText)
        {
            // Not reading date stuff currently
            string[] historyLines = fullText.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < historyLines.Length; i++)
            {
                string line = historyLines[i];
                if (line.Contains(".") && line.Contains("=") && line.Contains("{"))
                {
                    string date = line.Split('=')[0].Trim();
                    string contents = TextParser.GetContentsOfBrackets(fullText, date);
                    //Console.WriteLine(date+": "+contents);
                    fullText = fullText.Replace(contents, "");
                }
            }

            return fullText;
        }

        public void ReadStateHistory(string fullText)
        {
            string history = TextParser.GetContentsOfBrackets(fullText, "history");
            history = readAndRemoveDates(history);

            Owner = TextParser.getVariable(history, "owner");

            string buildings = TextParser.GetContentsOfBrackets(history, "buildings");
            Buildings = new BuildingsGroup();
            Buildings.ReadBuildingsContents(buildings);

            string vpContents = TextParser.GetContentsOfAllGroupsWithName(history, "victory_points");
            string[] vpLines = vpContents.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < vpLines.Length; i++)
            {
                string[] vpData = vpLines[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (vpData.Length > 1)
                {
                    //Console.WriteLine(vpLines[i]);
                    int provId = int.Parse(vpData[0].Trim());
                    int value = int.Parse(float.Parse(vpData[1].Trim()).ToString("0"));
                    VictoryPoints.Add(provId, value);
                }
            }

            string coresString = TextParser.GetAllVariables(history, "add_core_of");
            string[] cores = coresString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Cores = new List<string>(cores);
        }
    }

    
}
