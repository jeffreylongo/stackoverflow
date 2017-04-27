using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(redditTakeTwo.Startup))]
namespace redditTakeTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
