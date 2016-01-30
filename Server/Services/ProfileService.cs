using System.Linq;
using System.Net.Http;
using System.Data.Entity;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Services.Contracts;
using LearnWithQB.Server.Dtos;

namespace LearnWithQB.Server.Services
{
    public class ProfileService : IProfileService
    {
        protected readonly ILearnWithQBUow uow;

        public ProfileService(ILearnWithQBUow uow)
        {
            this.uow = uow;
        }

        public dynamic GetCurrentProfile(HttpRequestMessage request)
        {
            var username = request.GetRequestContext().Principal.Identity.Name;
            var user = uow.Users.GetAll()
                .Include(x => x.Accounts)
                .Include("Accounts.Profiles")
                .Single(x => x.Username == username);
            var account = user.Accounts.First();
            var profile = account.Profiles.First();
            return new ProfileDto(profile);
        }

        public void UpdateIsPersonalizedFlag(HttpRequestMessage request)
        {
            var username = request.GetRequestContext().Principal.Identity.Name;
            var user = uow.Users.GetAll()
                .Include(x => x.Accounts)
                .Include("Accounts.Profiles")
                .Single(x => x.Username == username);
            var account = user.Accounts.First();
            var profile = account.Profiles.First();
            profile.IsPersonalized = true;
            uow.SaveChanges();
        }
    }
}