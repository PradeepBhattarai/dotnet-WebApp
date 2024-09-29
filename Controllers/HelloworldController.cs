using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
namespace WebApp.Controllers;

public class HelloworldController : Controller
{ 
    public IActionResult Index(){
        return View();
    }
}
