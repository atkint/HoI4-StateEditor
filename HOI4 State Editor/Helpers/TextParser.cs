using HOI4_State_Editor.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Helpers
{
    public static class TextParser
    {
        public static string RemoveComment(string inputLine)
        {
            int indexOfComment = inputLine.IndexOf('#');
            if (indexOfComment >= 0)
            {
                inputLine = inputLine.Remove(indexOfComment);
            }

            return inputLine.Trim();
        }

        public static string GetAllVariables(string totalText, string variableName)
        {
            int lastIndex = 0;
            int nextIndex = 0;
            int counter = 0;
            string returnString = "";
            while (nextIndex != -1)
            {
                nextIndex = totalText.IndexOf(variableName, lastIndex + 1);
                if (nextIndex != -1)
                {
                    returnString += getVariable(totalText.Substring(nextIndex), variableName).Trim() + "\n";
                    counter++;
                }
                lastIndex = nextIndex;
            }

            return returnString;
        }

        public static string GetContentsOfAllGroupsWithName(string totalText, string groupName)
        {
            int lastIndex = 0;
            int nextIndex = 0;
            int counter = 0;
            string returnString = "";
            while (nextIndex != -1)
            {
                nextIndex = totalText.IndexOf(groupName, lastIndex + 1);
                if (nextIndex != -1)
                {
                    returnString += GetContentsOfBrackets(totalText.Substring(nextIndex), groupName).Trim()+"\n";
                    counter++;
                }
                lastIndex = nextIndex;
            }

            return returnString;
        }

        public static int GetTotalInstancesOfGroup(string totalText, string groupName)
        {
            int lastIndex = 0;
            int nextIndex = 0;
            int counter = 0;
            while (nextIndex != -1)
            {
                nextIndex = totalText.IndexOf(groupName,lastIndex+1);
                if (nextIndex != -1)
                {
                    counter++;
                }
                lastIndex = nextIndex;
            }

            return counter;
        }

        public static StateCategory CreateStateCategory(string file)
        {
            StateCategory newStateCat = new StateCategory();

            StreamReader sr = new StreamReader(file);
            string stateCategoryText = GetContentsOfBrackets(sr.ReadToEnd(),"state_categories");
            sr.Close();

            string tag = stateCategoryText.Split('=')[0].Trim();
            string name = tag;
            string typeText = GetContentsOfBrackets(stateCategoryText, tag);
            int buildingSlots = Convert.ToInt16(getVariable(typeText, "local_building_slots"));

            newStateCat.Tag = tag;
            newStateCat.Name = name;
            newStateCat.BuildingSlots = buildingSlots;

            return newStateCat;
        }

        public static ProvinceBuilding CreateProvinceBuilding(string line)
        {
            string[] lineSplit = RemoveComment(line).Split('=');
            if (lineSplit.Length > 1)
            {
                string buildingType = lineSplit[0].Trim();
                int value = int.Parse(lineSplit[1].Trim());
                ProvinceBuilding newBuilding = new ProvinceBuilding(buildingType, value);
                return newBuilding;
            }

            return null;
        }

        public static string getVariable(string totalText, string heading)
        {
            int headingIndex = totalText.IndexOf(heading);
            if (headingIndex>0)
            {
                if (totalText[headingIndex - 1] == '#')
                {
                    return "";
                }
            }
            if (headingIndex >= 0)
            {
                int endLineIndex = totalText.IndexOf('\n', headingIndex);
                string relevantLine = totalText.Substring(headingIndex, endLineIndex - headingIndex);
                string[] splitString = relevantLine.Trim().Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                return RemoveComment(splitString[1].Trim());
            }
            else
            {
                return "";
            }
        }

        public static string CleanAndCombineLines(string inputString, string concatString)
        {
            string[] lines = inputString.Split('\n');
            StringBuilder sb = new StringBuilder("");
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = RemoveComment(lines[i]);
                sb.Append(lines[i]+concatString);
            }
            return sb.ToString().Trim();
        }

        public static string GetContentsOfBrackets(string totalText, string heading)
        {
            if (totalText.Contains(heading))
            {
                int headingIndex = totalText.IndexOf(heading);
                int openBracketIndex = totalText.IndexOf('{', headingIndex) + 1;
                int closeBracketIndex = openBracketIndex;
                int counter = openBracketIndex;
                int bracketDepth = 0;
                while(counter <= totalText.Length-1)
                {
                    if (totalText[counter] == '{')
                    {
                        bracketDepth++;
                    }
                    if (totalText[counter] == '}')
                    {
                        if (bracketDepth == 0)
                        {
                            // Found close bracket
                            closeBracketIndex = counter;
                            break;
                        }
                        else
                        {
                            bracketDepth--;
                        }
                    }
                    counter++;
                }
                string contents = totalText.Substring(openBracketIndex, closeBracketIndex - openBracketIndex);
                return contents;
            }
            else
            {
                return "";
            }
        }

        public static string GetContentsOfBracketsConcatenated(string totalText, string heading, string concatString)
        {
            if (totalText.Contains(heading))
            {
                int headingIndex = totalText.IndexOf(heading);
                int openBracketIndex = totalText.IndexOf('{', headingIndex) + 1;
                int closeBracketIndex = totalText.IndexOf('}', headingIndex);
                string contents = totalText.Substring(openBracketIndex, closeBracketIndex - openBracketIndex);
                string[] lines = contents.Split(new char[] { '\n','\t'},StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sb = new StringBuilder("");
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = RemoveComment(lines[i]);
                    if (lines[i] != "")
                    {
                        sb.Append(lines[i] + concatString);
                    }
                }
                return sb.ToString().Trim();
            }
            else
            {
                return "";
            }
        }
    }
}
