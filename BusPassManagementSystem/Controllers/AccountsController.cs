using BusPassManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusPassManagementSystem.Controllers
{
    public class AccountsController : Controller
    {
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserMaster rg)
        {
            using(BusContext db = new BusContext())
            {
                db.UserMasters.Add(rg);
                db.SaveChanges();
                return RedirectToAction("Login","Accounts");
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel lg)
        {
            using (BusContext db = new BusContext())
            {
                var users = db.UserMasters.Where(x => x.UserId == lg.UserId && x.Password == lg.Password);
                if(users.Count() > 0)
                {
                    var user = users.FirstOrDefault();
                    HttpContext.Session.SetInt32("role", user.RoleId);
                    HttpContext.Session.SetString("name", user.Name);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    TempData["msg"] = "Incorrect UserId/Password";
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Accounts");
        }
    }
}
