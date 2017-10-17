using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arden.Startup))]
namespace Arden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
