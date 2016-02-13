using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KadhamDragon.Startup))]
namespace KadhamDragon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
