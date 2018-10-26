using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class Country
    {
        public string Name;
        public string Tag;
        public int Capital;
        public bool IsNewNation;
        public Color MainColour;
        public string History;
        public Politics Politics;
        public List<Leader> Leaders;
        public List<Commander> CorpsCommanders;
        public List<Commander> FieldMarshals;
        public List<Commander> NavalCommanders;

        public Country(string tag, string name, bool newNation)
        {
            Name = name;
            Tag = tag;
            IsNewNation = newNation;
            Politics = new Politics();
            Leaders = new List<Leader>();

            CorpsCommanders = new List<Commander>();
            FieldMarshals = new List<Commander>();
            NavalCommanders = new List<Commander>();
        }

        public override string ToString()
        {
            return Tag + ": " + Name;
        }
    }
}
