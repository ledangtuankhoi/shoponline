using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shoponline1.Startup))]
namespace Shoponline1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
