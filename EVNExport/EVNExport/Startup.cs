using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EVNExport.Startup))]
namespace EVNExport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
