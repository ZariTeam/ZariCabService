using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZariApp.Startup))]
namespace ZariApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
