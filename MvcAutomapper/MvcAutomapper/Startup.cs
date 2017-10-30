using AutoMapper;
using Microsoft.Owin;
using MvcAutomapper.App_Start;
using MvcAutomapper.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAutomapper.Startup))]

namespace MvcAutomapper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            AutoMapperConfig.Configure();
        }
    }
}