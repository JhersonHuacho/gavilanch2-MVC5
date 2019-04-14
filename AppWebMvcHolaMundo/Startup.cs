using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWebMvcHolaMundo.Startup))]
namespace AppWebMvcHolaMundo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
