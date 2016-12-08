using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HSPTL.Startup))]
namespace HSPTL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
