using System;
using System.Collections.Generic;
using System.Text;
using Entity_Layer;

namespace Logic_Layer
{
    public class ValidatorClient
    {
        public ValidationResult Validate(Client client)
        {
            ValidationResult result = new ValidationResult();
            ValidateDNI(result,client.DNI);
            ValidateName(result,client.Name, client.Lastname);
            ValidateEmail(result, client.Email);
            return result;
        }

        public ValidationResult Validate(int dni)
        {
            ValidationResult result = new ValidationResult();
            ValidateDNI(result, dni);
            return result;
        }

        // GENERIC VALIDATION FIELDS // 

        public void ValidateDNI(ValidationResult result, int dni)
        {
            if (!EntityRules.IsValidDNI(dni)) result.AddError("DNI must contains 8 digits.");
        }

        public void ValidateName(ValidationResult result, params string [] input)
        {
            foreach(string name in input)
            {
                if (!EntityRules.IsValidName(name)) result.AddError("Field must only contain letters.");
            }
        }

        public void ValidateEmail(ValidationResult result, string email)
        {
            if (!EntityRules.IsValidEmail(email)) result.AddError("Incorrect format of email");
        }
    }
}
