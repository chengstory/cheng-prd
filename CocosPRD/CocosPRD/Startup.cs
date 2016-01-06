using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CocosPRD.Startup))]
namespace CocosPRD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
