using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public enum COMMANDER_TYPE { FIELD_MARSHAL, CORPS_COMMANDER, NAVAL_COMMANDER }

    public class Commander
    {
        public string Name;
        public string Picture;
        public int Skill = 1;
        public List<string> Traits;

        public COMMANDER_TYPE CommanderType;

        public int AttackSkill = -1;
        public int DefendSkill = -1;
        public int PlanningSkill = -1;
        public int SupplySkill = -1;

        public Commander()
        {
            Traits = new List<string>();
        }

        public void ReadCommanderText(string leaderText, COMMANDER_TYPE com_type)
        {
            CommanderType = com_type;
            Name = TextParser.getVariable(leaderText, "name").Replace("\"","");
            string picturePath = TextParser.getVariable(leaderText, "portrait_path").Replace("\"","");
            Picture = picturePath != "" ? picturePath : TextParser.getVariable(leaderText, "gfx").Replace("\"", "");
            // Picture = picturePath != "" ? picturePath : TextParser.getVariable(leaderText, "picture").Replace("\"", "");
            //if (!Picture.ToUpper().Contains(".DDS"))
            //{
            //    Picture += ".DDS";
            //}
            Skill = Convert.ToInt16(TextParser.getVariable(leaderText, "skill"));

            AttackSkill = TextParser.getVariable(leaderText, "attack_skill") != "" ? Convert.ToInt16(TextParser.getVariable(leaderText, "attack_skill")) : -1;
            DefendSkill = TextParser.getVariable(leaderText, "defense_skill") != "" ? Convert.ToInt16(TextParser.getVariable(leaderText, "defense_skill")) : -1;
            PlanningSkill = TextParser.getVariable(leaderText, "planning_skill") != "" ? Convert.ToInt16(TextParser.getVariable(leaderText, "planning_skill")) : -1;
            SupplySkill = TextParser.getVariable(leaderText, "logistics_skill") != "" ? Convert.ToInt16(TextParser.getVariable(leaderText, "logistics_skill")) : -1;

            string traits = TextParser.GetContentsOfBrackets(leaderText, "traits").Trim();
            string[] traitsSplit = traits.Split(new char[] { ' ','#' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string t in traitsSplit)
            {
                Traits.Add(t);
            }
        }

        public override string ToString()
        {
            return Name+" (+"+Skill.ToString()+")";
        }
    }
}
