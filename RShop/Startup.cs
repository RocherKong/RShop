using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RShop.Startup))]
namespace RShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
