using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RCMD.Models;
using Microsoft.Owin;
using Owin;
using System.Security.Claims;

[assembly: OwinStartupAttribute(typeof(RCMD.Startup))]
namespace RCMD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
   
    // The following method we will create default User roles (Surveyor, Lab Technician and Material Engineers) and Administrator user for login
       
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup Creating first Administrator Role and creating a default Administrator User 
            if (!roleManager.RoleExists("Administrator"))
            {

                // first we create Administrator role
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Administrator";
                roleManager.Create(role);

                //Here we create a Administrator super user who will maintain the website				

                var user = new ApplicationUser();
                user.UserName = "eraAdmin";
                user.Email = "eraadmin@ERA.gov.et";

                string userPWD = "Pa$$W0rd";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Administrator
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Administrator");

                }
            }

            // Creating Surveyor role 
            if (!roleManager.RoleExists("Surveyor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Surveyor";
                roleManager.Create(role);

            }

            // Creating Engineer role 
            if (!roleManager.RoleExists("Engineer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Engineer";
                roleManager.Create(role);

            }
            // Creating Technician role 
            if (!roleManager.RoleExists("Technician"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Technician";
                roleManager.Create(role);
            }

        }
   
 }
}
