using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewStudentDetails()
    {
        return View();
    }
}
