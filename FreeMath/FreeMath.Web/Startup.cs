using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreeMath.Web.Startup))]
namespace FreeMath.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
