using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phase1_Project.Startup))]
namespace Phase1_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
