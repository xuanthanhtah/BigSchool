using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_04.Startup))]
namespace lab_04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
