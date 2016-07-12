using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebDeveloper.Models;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUserAndRole();
        }

        internal void CreateUserAndRole()
        {
            var context = new WebDeveloperDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<WebDeveloperUser>(new UserStore<WebDeveloperUser>(context));
            
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole {Name = "Admin"};
                roleManager.Create(role);

                var user = new WebDeveloperUser
                {
                    UserName = "juvega@gmail.com",
                    Email = "juvega@gmail.com"
                };

                var userPassword = "Passw0rd2016";

                var userCreation = userManager.Create(user, userPassword);
             
                if (userCreation.Succeeded)
                    userManager.AddToRole(user.Id, "Admin");
            }
            
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new IdentityRole {Name = "Manager"};
                roleManager.Create(role);

            }

            // creating Creating Employee role    
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new IdentityRole {Name = "Employee"};
                roleManager.Create(role);

            }
        }
    }
}
