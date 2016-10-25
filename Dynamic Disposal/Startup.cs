using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dynamic_Disposal.Startup))]
namespace Dynamic_Disposal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
