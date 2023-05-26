using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proje.Models;

namespace Proje.Controllers
{
    public class PersonelController : Controller
    {
        private UserManager<ApplicaitonUser> userManager;

        public PersonelController(UserManager<ApplicaitonUser> _userManager)
        {
            userManager = _userManager;
        }
        public IActionResult Liste()
        {
            return View(userManager.Users);
        }

        [HttpGet]
        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Kayit(Kayit kayit)
        {
            if (ModelState.IsValid)
            {
                ApplicaitonUser user = new ApplicaitonUser();
                user.UserName = kayit.UserName;
                user.Email = kayit.Email;
                
                var result = await userManager.CreateAsync(user, kayit.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Liste", "Personel");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                }
            }
            return View();

        }
    }
}
