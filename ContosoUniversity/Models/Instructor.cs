﻿using ContosoUniversity.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        public string FullName { get { return LastName + ", " + FirstMidName; } }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        public ICollection<CourseAssignment>? CourseAssignment { get; set; }
        public OfficeAssignment? OfficeAssignment { get; set; }
    }
}
