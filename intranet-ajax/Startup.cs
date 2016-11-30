using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(intranet_ajax.Startup))]
namespace intranet_ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
