using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootcampMagdeburg.Startup))]
namespace BootcampMagdeburg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
