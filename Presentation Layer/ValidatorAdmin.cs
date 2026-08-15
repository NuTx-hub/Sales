using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using Logic_Layer;

namespace Presentation_Layer
{
    public class ValidatorAdmin
    {
        public ValidationResult Validar(Admin admin) //REVIEW THIS.
        {
            var resultado = new ValidationResult { IsValid = true };

            if (!Validations.IsName(admin.Name, admin.Lastname))
                resultado.AgregarError("Field must not be empty.");

            if (!Validations.IsValidDNI(admin.DNI))
                resultado.AgregarError("It must have 8 digits.");

            if (!Validations.IsValidPassword(admin.Password))
                resultado.AgregarError("It must have atleast 6 digits.");

            return resultado;
        }
    }
}
