using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsNews.Startup))]
namespace SportsNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
