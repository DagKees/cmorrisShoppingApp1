using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cmorrisShoppingApp1.Startup))]
namespace cmorrisShoppingApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
