using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Scratchpad
{
    internal class USStatesMissingLetter
    {
        private List<string> allStates = new List<string>() {
            "alabama",
             "alaska",
             "arizona",
             "arkansas",
             "california",
             "colorado",
             "connecticut",
             "delaware",
             "florida",
             "georgia",
             "hawaii",
             "idaho",
             "illinois",
             "indiana",
             "iowa",
             "kansas",
             "kentucky",
             "louisiana",
             "maine",
             "maryland",
             "massachusetts",
             "michigan",
             "minnesota",
             "mississippi",
             "missouri",
             "montana",
             "nebraska",
             "nevada",
             "new hampshire",
             "new jersey",
             "new mexico",
             "new york",
             "north carolina",
             "north dakota",
             "ohio",
             "oklahoma",
             "oregon",
             "pennsylvania",
             "rhode island",
             "south carolina",
             "south dakota",
             "tennessee",
             "texas",
             "utah",
             "vermont",
             "virginia",
             "washington",
             "west virginia",
             "wisconsin",
             "wyoming"};
        public  List<char> FindmissingLetters()
        {
            List<char> missingLetters = new List<char>();
            bool[] myHash = new bool[26];
            for (int i = 0; i < myHash.Length; i++)
                myHash[i] = false; 

            foreach(string state in allStates)
            {
                foreach(char c in state.ToCharArray())
                    if(c != ' ')
                        myHash[(int)char.ToLower(c)-97] = true;
            }

            for (int i = 0; i < myHash.Length; i++)
            {
                if (!myHash[i])
                {
                    missingLetters.Add((char)(i + 97));
                }
            }

            return missingLetters; 
        }
    }
}
