using BusPassManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusPassManagementSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddPass()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPass(PassDetail pp)
        {
            using (BusContext db = new BusContext())
            {
                db.PassDetails.Add(pp);

                if (db.SaveChanges() > 0)
                {
                    TempData["msg"] = "Your details are submitted successfully";
                }
                return RedirectToAction("AddPass", "User");
            }
            return View();
        }

        public IActionResult ViewPass()
        {
            using (BusContext db = new BusContext())
            {
                List<PassDetail> passdetails = db.PassDetails.ToList();

                return View(passdetails);
            }
        }

        public IActionResult ViewBuses()
        {
            using (BusContext db = new BusContext())
            {
                List<BusDetail> busdetails = db.BusDetails.ToList();

                return View(busdetails);
            }
        }
    }
}
