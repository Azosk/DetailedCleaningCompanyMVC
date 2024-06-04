using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DetailedCleaningCompanyMVC.Models;

namespace DetailedCleaningCompanyMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AppointmentForm()
    {
        return View("AppointmentForm");
    }

[HttpPost]
public IActionResult AppointmentForm(Appointment appointment)
{
    // Check if the model state is valid
    if (ModelState.IsValid)
    {
        // Check if the Agree property is true
        if (appointment.Agree)
        {
            // If Agree is true, redirect to the appointment confirmation page
            return RedirectToAction("AppointmentConfirmation");
        }
        else
        {
            // If Agree is false, add a model error
            ModelState.AddModelError("Agree", "You must agree to the terms and conditions.");
            using (var console = System.Console.Out)
            {
                console.WriteLine("Agree is false");
            }
        }
    }

    // If the model state is not valid or Agree is false, return the form view with the current model
    return View("AppointmentForm", appointment);
}


    public IActionResult Services()
    {
        return View("Services");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
