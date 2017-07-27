using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smoke.Startup))]
namespace Smoke
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
