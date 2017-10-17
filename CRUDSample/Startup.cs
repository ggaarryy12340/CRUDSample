using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDSample.Startup))]
namespace CRUDSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
