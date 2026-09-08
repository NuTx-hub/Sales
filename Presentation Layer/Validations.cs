using System;
using System.Collections.Generic;
using System.Text;
using Entity_Layer;

namespace Presentation_Layer
{
    public static class Validations
    {
        public static bool IsEmptyField(params string[] stringList)
        {
            foreach(string c in stringList)
            {
                if(string.IsNullOrWhiteSpace(c)) return true;
            }
            return false;
        }

        public static bool IsNumber(string input)
        {
            if(string.IsNullOrEmpty(input)) return false;
            if (int.TryParse(input, out int number)) return true;
            else return false;
        }

        public static bool IsString(params string []input) //fix to O(n)
        {
            if(input == null) return false;
            for(int i =0; i<input.Length; i++)
            {
                foreach(char c in input[i])
                {
                    if(!(char.IsLetter(c))) return false;
                }
            }
            return true;
        }
    }
}
