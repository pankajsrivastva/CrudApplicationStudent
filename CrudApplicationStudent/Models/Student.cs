using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudApplicationStudent.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [MinLength(10)]
        public string? Mobile { get; set; }
        public string? Std { get; set; }
        public bool? Status { get; set; }
    }
}
