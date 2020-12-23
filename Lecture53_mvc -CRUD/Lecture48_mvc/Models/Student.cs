using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Lecture48_mvc.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage ="please enter your age")]
        [Range(1,100)]
        public int? Age { get; set; }
        [Required(ErrorMessage ="enter cgpa")]
        public float? CGPA { get; set; }
        [Required(ErrorMessage ="enter your semester")]
        public string Semester { get; set; }
    }
}
