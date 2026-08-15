using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Entity_Layer;

namespace Logic_Layer
{
    public static class EntityRules
    {
        public static bool IsValidName(params string[] input) // OPTIMIZE THIS LATER. ACTUAL O(n^2)
        {
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(input[i])) return false;

                    foreach (char c in input[i])
                    {
                        if (!char.IsLetter(c)) return false;
                    }
                }
                return true;
            }
            else return false;
        }

        public static bool IsValidPassword(string input)
        {
            if (input == null || input.Length < 6) return false;
            return true;
        }

        public static bool IsValidDNI(int dni)
        {
            return dni >= 10000000 && dni <= 99999999;
        }

        public static bool IsValidEmail(string input)
        {
            var validEmail = new MailAddress(input);
            return validEmail.Address == input;
        }
    }
}
