using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MHRCMS.WebMVC.Startup))]
namespace MHRCMS.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
