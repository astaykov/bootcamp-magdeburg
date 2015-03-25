using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootcampBerlin.Startup))]
namespace BootcampBerlin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
