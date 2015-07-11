using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComboPortal.Startup))]
namespace ComboPortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
