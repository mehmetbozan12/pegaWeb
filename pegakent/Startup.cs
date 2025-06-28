using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pegakent.Startup))]
namespace pegakent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
