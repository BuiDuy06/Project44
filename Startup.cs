using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Webbanhang.Startup))]
namespace Project_Webbanhang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
