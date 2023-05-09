using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerRegSystem.Startup))]
namespace CustomerRegSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
