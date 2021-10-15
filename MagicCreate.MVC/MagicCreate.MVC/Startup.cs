using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MagicCreate.MVC.Startup))]
namespace MagicCreate.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
