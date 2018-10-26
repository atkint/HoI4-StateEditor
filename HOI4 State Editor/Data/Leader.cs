using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HOI4_State_Editor.Data
{
    public class Leader
    {
        public string Name;
        public string Description;
        public string Picture;
        public string ExpireDate;
        public string Ideology;
        public List<string> Traits;

        public Leader()
        {
            Traits = new List<string>();
        }

        public override string ToString()
        {
            return Name;
        }

        public void ReadLeaderText(string leaderText)
        {
            Name = TextParser.getVariable(leaderText, "name").Replace("\"","");
            Description = TextParser.getVariable(leaderText, "desc").Replace("\"", "");
            Picture = TextParser.getVariable(leaderText, "picture").Replace("\"", "");
            ExpireDate = TextParser.getVariable(leaderText, "expire");
            Ideology = TextParser.getVariable(leaderText, "ideology");
            string traits = TextParser.GetContentsOfBrackets(leaderText, "traits").Trim();
            string[] traitsSplit = traits.Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string t in traitsSplit)
            {
                Traits.Add(t);
            }
        }
    }
}
