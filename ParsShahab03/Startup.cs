using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParsShahab03.Startup))]
namespace ParsShahab03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
