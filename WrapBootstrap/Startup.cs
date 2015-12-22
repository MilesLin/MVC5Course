using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WrapBootstrap.Startup))]
namespace WrapBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
