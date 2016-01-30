using System;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using LearnWithQB.Server.Config.Contracts;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Dtos;
using LearnWithQB.Server.Services.Contracts;

namespace LearnWithQB.Server.Services
{
    public class AccountService : IAccountService
    {
        public AccountService(ILearnWithQBUow uow, IConfigurationProvider configurationProvider)
        {
            this.uow = uow;
            this.stripeConfiguration = configurationProvider.Get<IStripeConfiguration>();
        }

        public dynamic GetCurrentAccount(HttpRequestMessage request)
        {
            var username = request.GetRequestContext().Principal.Identity.Name;
            var user = uow.Users.GetAll()
                .Include(x => x.Accounts)
                .Single(x => x.Username == username);

            var account = user.Accounts.First();
            return new AccountDto(account);
        }

        public dynamic GetBilling(HttpRequestMessage request)
        {
            throw new NotImplementedException();
        }

        protected readonly ILearnWithQBUow uow;

        protected readonly IStripeConfiguration stripeConfiguration;
    }
}