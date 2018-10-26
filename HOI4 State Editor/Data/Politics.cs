using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class Politics
    {
        static int NEUTALITY_INDEX = 0;
        static int DEMOCRATIC_INDEX = 1;
        static int COMMUNISM_INDEX = 2;
        static int FASCISM_INDEX = 3;

        public string RulingParty = "neutrality";
        public string LastElection = "1930.1.1";
        public int ElectionFrequency = 48;
        public string ElectionsAllowed = "no";
        public Dictionary<string, int> IdeologyPopularity = new Dictionary<string, int>();
        public Dictionary<string, string> IdeologyBanned = new Dictionary<string, string>();

        public bool GetElectionsAllowed()
        {
            return ElectionsAllowed == "yes";
        }

        public int GetRulingPartyIndex()
        {
            switch(RulingParty)
            {
                case "neutrality":
                    return NEUTALITY_INDEX;
                case "democratic":
                    return DEMOCRATIC_INDEX;
                case "communism":
                    return COMMUNISM_INDEX;
                case "fascism":
                    return FASCISM_INDEX;
            }
            return -1;
        }

        public DateTime GetLastElectionDate()
        {
            if (LastElection.Trim() != "")
            {
                //Console.WriteLine(LastElection);
                string[] dateSplit = LastElection.Replace("\"","").Trim().Split('.');
                int year = int.Parse(dateSplit[0]);
                int month = int.Parse(dateSplit[1]);
                int day = int.Parse(dateSplit[2]);
                return new DateTime(year, month, day);
            }
            return new DateTime(1936, 1, 1);
        }

        public Politics()
        {
            IdeologyPopularity = new Dictionary<string, int>();
            IdeologyBanned = new Dictionary<string, string>();
        }

        public void ReadPolitics(string tag, string politicsText)
        {
            string partiesText = TextParser.GetContentsOfBrackets(politicsText, "parties");
            string[] lines = partiesText.Split('\n');
            for(int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim(); // Clean the text, remove comments and white space
                if (line.IndexOf("#") >= 0)
                {
                    line = line.Remove(line.IndexOf("#"));
                }
                //Console.WriteLine(line);
                if (line.Contains('=') && line.Contains('{')) // this is definitely an ideology
                {
                    string ideology = line.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                    string contents = TextParser.GetContentsOfBrackets(politicsText, ideology);
                    string popularity = TextParser.getVariable(contents,"popularity").Trim();
                    string banned = TextParser.getVariable(contents, "banned").Trim();
                    //Console.WriteLine(tag+": ("+banned+")");
                    IdeologyPopularity.Add(ideology, int.Parse(popularity));
                    if (banned != "")
                    {
                        IdeologyBanned.Add(ideology, banned);
                    }
                }
            }

            RulingParty = TextParser.getVariable(politicsText, "ruling_party");
            LastElection = TextParser.getVariable(politicsText, "last_election");
            string frequency = TextParser.getVariable(politicsText, "election_frequency");
            ElectionFrequency = frequency != "" ? Convert.ToInt32(TextParser.getVariable(politicsText, "election_frequency")) : -1;
            ElectionsAllowed = TextParser.getVariable(politicsText, "elections_allowed");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("set_politics = {");
            sb.AppendLine("\tparties = {");

            foreach(string ideology in IdeologyPopularity.Keys)
            {
                sb.AppendLine("\t\t"+ideology+" = {");
                sb.AppendLine("\t\t\tpopularity = "+IdeologyPopularity[ideology]);
                if (IdeologyBanned.ContainsKey(ideology))
                {
                    sb.AppendLine("\t\t\tbanned = "+IdeologyBanned[ideology]);
                }
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine();
            if (RulingParty != "")
                sb.AppendLine("\truling_party = " + RulingParty);
            if (LastElection != "")
                sb.AppendLine("\tlast_election = " + LastElection);
            if (ElectionFrequency != -1)
                sb.AppendLine("\telection_frequency = " + ElectionFrequency.ToString());
            if (ElectionsAllowed != "")
                sb.AppendLine("\telections_allowed = " + ElectionsAllowed);
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
    
}
