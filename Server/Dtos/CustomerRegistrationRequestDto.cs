using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnWithQB.Server.Dtos
{
    public class CustomerRegistrationRequestDto
    {
        public CustomerRegistrationRequestDto()
        {

        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string ConfirmEmail { get; set; }

        public string Password { get; set; }
    }
}