using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salary
{
    public class Salary
    {
        [Key]
        public Guid Id { get; set; }
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
