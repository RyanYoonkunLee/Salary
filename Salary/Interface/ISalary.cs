using System;
using System.Collections.Generic;
using System.Text;

namespace Salary.Interface
{
    public interface ISalary
    {
        List<Salary> GetAllSalaries();
        Salary GetSalaryById(Guid id);
        void CreateSalary(Salary sal);
        void UpdateSalary(Salary sal);
        void DeleteSalary(Salary sal);
    }
}
