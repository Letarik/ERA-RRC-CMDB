using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using RCMD.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RCMD.Controllers
{
	[Authorize]
	public class UsersController : Controller
    {
		// GET: Administrator Users
		public Boolean isAdminUser()
		{
			if (User.Identity.IsAuthenticated)
			{
				var user = User.Identity;
				ApplicationDbContext context = new ApplicationDbContext();
				var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
				var s = UserManager.GetRoles(user.GetUserId());
				if (s[0].ToString() == "Administrator")
				{
					return true;
				}
                else
				{
					return false;
				}
			}
			return false;
		}
        public Boolean IsEngineerUser()
        {
            if(User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Engineer")
                {
                    return true;
                }
                else
                   
                {
                    return false;
                }
            }
            return false;
        }
        public Boolean isTechnicianUser()
        {
            if(User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Technician")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public Boolean isSurveyorUser()
        {
            if (User.Identity.IsAuthenticated)
            { 
            var user = User.Identity;
            ApplicationDbContext context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var s = UserManager.GetRoles(user.GetUserId());
            if (s[0].ToString() == "Surveyor")
            {
                return true;
            }
             else
                {
                    return false;
                }
            }
            return false;
        }
		public ActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
			{
				var user = User.Identity;
				ViewBag.Name = user.Name;
				//	ApplicationDbContext context = new ApplicationDbContext();
				//	var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

				//var s=	UserManager.GetRoles(user.GetUserId());
				ViewBag.displayMenu = "0";

                if (isAdminUser())
                {
                    ViewBag.displayMenu = "1";
                }
                else
                  if (IsEngineerUser())
                {
                    ViewBag.displayMenu = "2";
                }
                else
                    if(isTechnicianUser())
                {
                    ViewBag.displayMenu = "3";
                }
                else
                    if (isSurveyorUser())
                {
                    ViewBag.displayMenu = "4";
                }
                return View();
			}
			else
			{
				ViewBag.Name = "Not Logged IN";
			}
            
			return View();
		}
	}
}