using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBazarEcom.Web.Startup))]
namespace ClothBazarEcom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
