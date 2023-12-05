using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.Dtos.IdentitiyDtos
{
    public class UserEditDto
    {
        public string Mail { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public sbyte ConfirmPassword { get; set; }

    }
}
