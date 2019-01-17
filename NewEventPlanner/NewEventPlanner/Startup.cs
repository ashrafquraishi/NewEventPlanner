using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NewEventPlanner.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewEventPlanner.Startup))]
namespace NewEventPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();

            ConfigureAuth(app);
            CreateRolls();
        }
        private void CreateRolls()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!roleManager.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Business"))
            {
                var role = new IdentityRole();
                role.Name = "Business";
                roleManager.Create(role);
            }
        }
    }
}
