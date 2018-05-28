using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(belnovosti.Startup))]
namespace belnovosti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
