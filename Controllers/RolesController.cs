using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UserRoleAdmin.Controllers
{
    public class RolesController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RolesController(RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
        }

        public IActionResult Index() => View(roleManager.Roles);
    }
}
