using Microsoft.AspNetCore.Mvc;

namespace Animal_Shelter
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}