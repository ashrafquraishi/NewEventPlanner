using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewEventPlanner.Startup))]
namespace NewEventPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
