using BusPassManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusPassManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AddBus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBus(BusDetail bd)
        {
            using (BusContext db = new BusContext())
            {
                db.BusDetails.Add(bd);

                if (db.SaveChanges() > 0)
                {
                    TempData["msg"] = "Your details are submitted successfully";
                }
                return RedirectToAction("AddBus", "Admin");
            }
            return View();
        }

        public IActionResult UpdateRoute()
        {
            using (BusContext db = new BusContext())
            {
                List<BusDetail> busdetails = db.BusDetails.ToList();

                return View(busdetails);
            }
        }

        
        public IActionResult Edit()
        {
            using(BusContext db = new BusContext())
            {
                var bus = db.BusDetails.Where(x => x.Id == x.Id).FirstOrDefault();


                return View(bus); 
            }
            
            
        }

        /*[HttpPost]
        public IActionResult Edit(BusDetail bus)
        {
            using (BusContext db = new BusContext())
            {
                var 


                return View(bus);
            }


        }*/
        /*[HttpPost]
        public IActionResult Edit(BusDetail bd)
        {
            using (BusContext db = new BusContext())
            {
                var bus = db.BusDetails.Where(x => x.Id == bd.Id).FirstOrDefault();

                db.BusDetails.Remove(bus);
                db.BusDetails.Add(bd);
                if (db.SaveChanges() > 0)
                {
                    TempData["msg"] = "Your details are Updated successfully";
                }
                return RedirectToAction("UpdateRoute", "Admin");

            }
            return View();
        }*/


    }
}
