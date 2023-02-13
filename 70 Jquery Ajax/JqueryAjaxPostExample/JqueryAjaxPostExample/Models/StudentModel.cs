using System.ComponentModel.DataAnnotations;

namespace JqueryAjaxPostExample.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="You need to enter name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
