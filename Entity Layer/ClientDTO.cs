using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    //Allows to create a DTO for the Cliente entity, which is used to transfer data between layers of the application.
    public record ClientDTO
    {
        public int CiCliente { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
    }

    public record ClienteDTOWithEmail : ClientDTO
    {
        public string Email { get; init; }
    }
}
