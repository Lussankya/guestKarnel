using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(guestTravel.Startup))]
namespace guestTravel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
