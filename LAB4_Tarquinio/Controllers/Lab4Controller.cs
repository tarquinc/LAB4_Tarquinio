using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LAB4_Tarquinio.Controllers
{
    public class Lab4Controller : Controller
    {

        public IActionResult Index()
        {
            //Do the formatting and computation here
            DateTime date = DateTime.Now;
            TimeSpan morning = new TimeSpan(11, 59, 59);
            TimeSpan afternoon = new TimeSpan(18, 0, 0);
            TimeSpan night = new TimeSpan(24, 0, 0);
            DateTime year = new DateTime(date.Year, 12, 31, 23, 59, 59);

            if (date.TimeOfDay <= morning)
            {
                ViewData["TimeOfDay"] = "Good Morning!";
            } else if ((date.TimeOfDay <= afternoon) && (date.TimeOfDay > morning)) {
                ViewData["TimeOfDay"] = "Good Afternoon!";
            } else if ((date.TimeOfDay > afternoon) && (date.TimeOfDay <= night)) {
                ViewData["TimeOfDay"] = "Good Evening!";
            } else
            {
                ViewData["TimeOfDay"] = "No Time to Display";
            }

            TimeSpan difference = year.Subtract(date);

            ViewData["DaysLeft"] = "There are " + difference.Days + " days left in " + date.Year + ".";


            return View(date);
        }


        public IActionResult Page2(int? id)
        {
            return View(id);
        }

        public IActionResult Page3()
        {
            string[] beverages = { "Apple Juice", "Coke", "Milk", "Water", "Orange Juice" };
            ViewData["Title"] = "Beverages";
            return View(beverages);
        }
    
    }
}