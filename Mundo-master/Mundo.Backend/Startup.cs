using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mundo.Backend.Startup))]
namespace Mundo.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
