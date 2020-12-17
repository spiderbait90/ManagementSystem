using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public string Author { get; set; }

        [Required]
        public string Content { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}