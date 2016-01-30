using System.Collections.Generic;
using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Dtos
{
    public class CustomerProfileDto : ProfileDto
    {
        public CustomerProfileDto()
        {

        }

        public new ProfileType ProfileType { get { return ProfileType.Customer; } }
    }
}