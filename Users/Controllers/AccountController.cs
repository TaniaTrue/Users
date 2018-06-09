using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Users.Models;

namespace Users.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
[AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (ModelState.IsValid)
            {
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel details, string returnUrl)
        {
            return View(details);
        }
    }
}
// When a user
//requests a restricted URL, they are redirected to the /Account/Login URL with a query string that specifies the URL
//that the user should be sent back to once they have been authenticated.