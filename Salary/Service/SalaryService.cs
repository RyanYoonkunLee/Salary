using Salary.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salary.Service
{
    public class SalaryService
    {
        public Salary CreateModelToData(SalaryCreateModel salaryView)
        {
            Salary salary = new Salary();
            salary.Id = Guid.NewGuid();
            salary.Name = salaryView.Name;
            salary.Income = salaryView.Income;
            salary.KiwiSaver = salaryView.KiwiSaver;
            salary.StudentLoan = salaryView.StudentLoan;

            return salary;
        }
    }
}
