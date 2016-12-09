using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project2MissionSite.Startup))]
namespace Project2MissionSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
