using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QxsqWebOnGitHub.Startup))]
namespace QxsqWebOnGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
