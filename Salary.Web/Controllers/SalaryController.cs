using Microsoft.AspNetCore.Mvc;
using Salary.Data.Data;
using Salary.Interface;
using Salary.Service;
using Salary.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.Web.Controllers
{
    public class SalaryController : Controller
    {
        SalaryService salaryService;
        ISalary _salary;

        public SalaryController(ISalary salary)
        {
            salaryService = new SalaryService();
            _salary = salary;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateSalary(SalaryCreateModel sal)
        {
            var item = salaryService.CreateModelToData(sal);
            _salary.CreateSalary(item);

            return RedirectToAction("ResultSalary", "Salary", item);
        }

        public IActionResult ResultSalary(Salary salary)
        {
            return View();
        }
    }
}
