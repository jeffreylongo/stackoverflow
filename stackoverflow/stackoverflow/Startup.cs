using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stackoverflow.Startup))]
namespace stackoverflow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
