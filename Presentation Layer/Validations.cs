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
                if(string.IsNullOrWhiteSpace(c)) return false;
            }
            return true;
        }
    }
}
