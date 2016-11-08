using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteDown.Startup))]
namespace SiteDown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
