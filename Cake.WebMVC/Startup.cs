using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cake.WebMVC.Startup))]
namespace Cake.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
