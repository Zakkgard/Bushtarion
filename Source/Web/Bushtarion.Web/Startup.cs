using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bushtarion.Web.Startup))]
namespace Bushtarion.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
