using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rc019415MIS4200.Startup))]
namespace rc019415MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
