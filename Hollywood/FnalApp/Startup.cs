using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FnalApp.Startup))]
namespace FnalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
