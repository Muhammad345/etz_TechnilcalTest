using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ETZ.Data;
using ETZ.ViewModel;
using ETZ.Services;

namespace ETZ.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService EmployeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        // GET: Employees
        public IActionResult Index()
        {
            return View(EmployeeService.GetEmployee_Listing());
        }
    }
}
