using Microsoft.AspNetCore.Mvc;
using NumberToWords.Models;

namespace NumberToWords.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ActionResult HomePage() { return View(); }

    [Route("/numAnswer")]
    public ActionResult numAnswer(string numInput) 
    {
      Conversion newConversion = new Conversion(numInput);
      // int result = newConversion.Dictionary(numInput);
      return View(newConversion);
    }
}

// dotnet watch run --launch-profile "production"