using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QxsqWebAdmin.Startup))]
namespace QxsqWebAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
