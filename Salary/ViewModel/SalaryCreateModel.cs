using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salary.ViewModel
{
    public class SalaryCreateModel
    {
        [Required]
        [DisplayName("Company Name")]
        public string Name { get; set; }
        [Required]
        public float Income { get; set; }
        [Required]
        public int KiwiSaver { get; set; }
        [Required]
        public bool StudentLoan { get; set; }
    }
}
