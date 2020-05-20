using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(northwindWeb.Startup))]
namespace northwindWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
