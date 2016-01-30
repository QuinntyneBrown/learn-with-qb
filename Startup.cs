using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LearnWithQB.Startup))]

namespace LearnWithQB
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
