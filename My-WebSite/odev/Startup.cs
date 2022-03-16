using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(odev.Startup))]
namespace odev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
