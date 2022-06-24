using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthAuthorProjects.Startup))]
namespace AuthAuthorProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
