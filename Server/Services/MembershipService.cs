using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Dtos;
using LearnWithQB.Server.Models;
using LearnWithQB.Server.Services.Contracts;

namespace LearnWithQB.Server.Services
{
    public class MembershipService: IMembershipService
    {
        public MembershipService(ILearnWithQBUow LearnWithQBUow)
        {

        }

        public void Register(RegistrationRequestDto registrationRequestDto)
        {

        }

        protected ILearnWithQBUow LearnWithQBUow;
    }
}