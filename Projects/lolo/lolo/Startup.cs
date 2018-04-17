using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lolo.Startup))]
namespace lolo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
