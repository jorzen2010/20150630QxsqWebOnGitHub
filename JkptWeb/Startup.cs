using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JkptWeb.Startup))]
namespace JkptWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
