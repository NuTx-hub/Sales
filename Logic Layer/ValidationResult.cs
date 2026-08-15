using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public void AgregarError(string mensaje)
        {
            Errors.Add(mensaje);
            IsValid = false;
        }
    }
}
