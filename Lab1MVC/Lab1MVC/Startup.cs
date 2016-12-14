using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1MVC.Startup))]
namespace Lab1MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
