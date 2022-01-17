using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ecrap.Startup))]
namespace Ecrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
