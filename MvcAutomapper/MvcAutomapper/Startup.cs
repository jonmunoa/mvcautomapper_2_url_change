using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAutomapper.Startup))]
namespace MvcAutomapper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
