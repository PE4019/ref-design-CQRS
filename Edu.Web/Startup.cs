using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Edu.Web.Startup))]
namespace Edu.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
