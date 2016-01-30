using Common.Caching;
using Common.Caching.Contracts;
using Microsoft.Practices.Unity;
using LearnWithQB.Server.Config;
using LearnWithQB.Server.Config.Contracts;
using LearnWithQB.Server.Data;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Services;
using LearnWithQB.Server.Services.Contracts;

namespace LearnWithQB.Server
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer(bool useMock = false)
        {
            var container = new UnityContainer();
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<ILearnWithQBUow, LearnWithQBUow>();
            container.RegisterType<ILearnWithQBContext, LearnWithQBContext>();
            container.RegisterType<ISessionService, SessionService>();
            container.RegisterType<IIdentityService, IdentityService>();
            container.RegisterType<IEncryptionService, EncryptionService>();
            container.RegisterType<ICacheProvider, CacheProvider>();
            container.RegisterType<ISecurityService, SecurityService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<IProfileService, ProfileService>();
            container.RegisterType<IEmailService, EmailService>();
            container.RegisterType<IEmailBuilder, EmailBuilder>();
            container.RegisterType<IConfigurationProvider, ConfigurationProvider>();

            return container;
        }
    }
}