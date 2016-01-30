
using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using LearnWithQB.Server.Config;
using LearnWithQB.Server.Services.Contracts;

namespace LearnWithQB.Server.Auth
{
    public class OAuthOptions : OAuthAuthorizationServerOptions
    {
        public OAuthOptions(LearnWithQB.Server.Services.Contracts.IIdentityService identityService)
        {
            var config = AppConfiguration.Config;

            TokenEndpointPath = new PathString(config.TokenPath);
            AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(config.ExpirationMinutes);
            AccessTokenFormat = new JwtWriterFormat(this);
            Provider = new OAuthProvider(identityService);
            AllowInsecureHttp = true;
        }

    }
}
