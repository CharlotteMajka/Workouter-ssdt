using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private WorkoutManager workoutManager = new WorkoutManager();

        public IActionResult Index()
        {
            var model = new IndexViewModel();
            model.WorkoutTypes = workoutManager.GetAllTypes();
            model.Workouts = workoutManager.GetAllWorkouts();
            return View(model);
        }

        public IActionResult Save(double distance, int type)
        {
            workoutManager.Save(distance, type);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
