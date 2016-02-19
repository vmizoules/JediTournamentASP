using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JediWebSiteApplication.Startup))]
namespace JediWebSiteApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
