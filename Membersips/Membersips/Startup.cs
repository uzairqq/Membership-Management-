using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membersips.Startup))]
namespace Membersips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
