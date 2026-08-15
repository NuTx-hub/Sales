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
            foreach (char c in input)
            {
                if (!char.IsNumber(c)) return false;
            }
            return true;
        }

        //public static bool IsEmail(string input)
        //{
        //    if(string.)
        //}

        public static bool IsName(params string []input) // OPTIMIZE THIS LATER. ACTUAL O(n^2)
        {
            for (int i = 0; i<input.Length; i ++)
            {
                if(string.IsNullOrWhiteSpace(input[i])) return false;

                foreach (char c in input[i])
                {
                    if (!char.IsLetter(c)) return false;
                }
            }
            return true;
        }

        public static bool IsValidPassword(string input)
        {
            if (input == null || input.Length < 6) return false;
            return true;
        }

        public static bool IsString(string input)
        {
            if(input == null) return false;
            foreach(char c in input)
            {
                if(!(char.IsLetter(c))) return false;
            }
            return true;
        }

        public static bool IsValidDNI(int dni)
        {
            return dni >= 10000000 && dni <= 99999999;
        }
    }
}
