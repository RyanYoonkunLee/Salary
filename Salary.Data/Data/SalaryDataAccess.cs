using Salary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salary.Data.Data
{
    public class SalaryDataAccess : ISalary
    {
        private readonly SalaryDBContext _sal;

        public SalaryDataAccess(SalaryDBContext salary)
        {
            _sal = salary;
        }

        public void CreateSalary(Salary sal)
        {
            _sal.Salaries.Add(sal);
            _sal.SaveChanges();
        }

        public void DeleteSalary(Salary sal)
        {
            _sal.Salaries.Remove(sal);
            _sal.SaveChanges();
        }

        public List<Salary> GetAllSalaries()
        {
            List<Salary> salaries = _sal.Salaries.ToList();
            return salaries;
        }

        public Salary GetSalaryById(Guid id)
        {
            var item = _sal.Salaries.Where(m => m.Id == id).First();
            return item;
        }

        public void UpdateSalary(Salary sal)
        {
            _sal.Salaries.Update(sal);
            _sal.SaveChanges();
        }
    }
}
