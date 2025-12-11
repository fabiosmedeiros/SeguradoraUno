using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguradoraUno.Web.Startup))]
namespace SeguradoraUno.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
