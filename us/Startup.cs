using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(us.Startup))]
namespace us
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
