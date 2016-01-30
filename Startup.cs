using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(LearnWithQB.Startup))]

namespace LearnWithQB
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(LearnWithQB.Server.UnityConfiguration.GetContainer());

            GlobalConfiguration.Configure(config => LearnWithQB.Server.ApiConfiguration.Install(config, app));
        }
    }
}
