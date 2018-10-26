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
    public class CountryCreator
    {
        public static void CreateCountry(Country country)
        {
            StreamWriter sw = new StreamWriter(ModFileReader.FolderPath+"history/countries/new/"+country.Tag+" - "+country.Name);
            sw.WriteLine("capital = "+country.Capital.ToString());
            sw.WriteLine();

            sw.WriteLine("#oob = \""+country.Tag+"_YEAR\"");
            sw.WriteLine();

            sw.WriteLine("set_research_slots = 3");
            sw.WriteLine();

            sw.WriteLine("set_technology = {");
            sw.WriteLine("}");
            sw.WriteLine("");

            sw.WriteLine(country.Politics.ToString());
            sw.WriteLine();

            sw.WriteLine("set_national_unity = 0.50");
            sw.Close();
        }

    }
}
