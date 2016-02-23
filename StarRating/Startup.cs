using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarRating.Startup))]
namespace StarRating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
