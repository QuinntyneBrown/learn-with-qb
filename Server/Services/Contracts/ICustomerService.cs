using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnWithQB.Server.Dtos;

namespace LearnWithQB.Server.Services.Contracts
{
    public interface ICustomerService
    {
        CustomerRegistrationResponseDto TryToRegister(CustomerRegistrationRequestDto dto);

        CustomerDto GetByEmail(string email);
    }
}