using Microsoft.Owin.Security.Jwt;
using LearnWithQB.Server.Config;
using LearnWithQB.Server.Config.Contracts;

namespace LearnWithQB.Server.Auth
{
    public class JwtOptions : JwtBearerAuthenticationOptions
    {
        public JwtOptions(IConfigurationProvider configurationProvider)
        {
            var config = AppConfiguration.Config;

            AllowedAudiences = new[] { config.JwtAudience };
            IssuerSecurityTokenProviders = new[] 
            {
                new SymmetricKeyIssuerSecurityTokenProvider(config.JwtIssuer, config.JwtKey)
            };
        }
    }
}