using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(beckAppCordova.Startup))]
namespace beckAppCordova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
