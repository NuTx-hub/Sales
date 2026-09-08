using Entity_Layer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;


namespace Logic_Layer
{
    public class ValidatorAdmin
    {
        //It validates the data from an admin.
        public ValidationResult Validate(Admin admin) //REVIEW THIS.
        {
            //Set true by default.
            var result = new ValidationResult { IsValid = true };

            //Validate fields.
            ValidateDNI(result, admin.DNI);
            ValidateName(result, admin.Lastname, admin.Name);
            ValidatePassword(result, admin.Password);

            return result;
        }

        // Log in admin validation.
        public ValidationResult Validate(int dni, string password)
        {
            var result = new ValidationResult { IsValid = true };
            ValidateDNI(result, dni);
            ValidatePassword(result, password);

            return result;
        }


        // GENERIC VALIDATES FIELDS // 

        public void ValidatePassword(ValidationResult result, string password)
        {
            if (!EntityRules.IsValidPassword(password))
                result.AddError("Password it must contain atleast 6 digits.");
        }

        private void ValidateName(ValidationResult result, params string[] names)
        {
            foreach(var name in names)
            {
                if (!EntityRules.IsValidName(name))
                    result.AddError("Name and Lastname must only contain letters.");
            }
        }

        private void ValidateDNI(ValidationResult result, int dni)
        {
            if (!EntityRules.IsValidDNI(dni))
                result.AddError("It must have 8 digits.");
        }
    }
}
