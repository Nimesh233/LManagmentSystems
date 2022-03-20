using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMSystem.Startup))]
namespace LMSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
