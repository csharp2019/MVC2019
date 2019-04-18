using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poklon.Startup))]
namespace Poklon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
