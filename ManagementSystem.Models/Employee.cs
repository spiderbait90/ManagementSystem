using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Joined Date")]
        public DateTime JoinedDate { get; set; } = DateTime.Now;

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Monthly Salary")]
        public decimal MonthlySalary { get; set; }

        [Required]
        public string Department { get; set; }

        public int? ManagerId { get; set; }

        public Employee Manager { get; set; }

        [Display(Name = "Comments Count")]
        public List<Comment> Comments { get; set; }
    }
}
