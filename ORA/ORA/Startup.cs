using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORA.Startup))]
namespace ORA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
