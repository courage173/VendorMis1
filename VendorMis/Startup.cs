using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VendorMis.Startup))]
namespace VendorMis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
