using Microsoft.AspNetCore.Mvc;

namespace ChartJsTest.Controllers;

public class ChartController : Controller {
    public IActionResult Index(){
        return View();
    }
}