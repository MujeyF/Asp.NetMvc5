using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Test.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [FirstNameValidation]
        [MaxLength(20, ErrorMessage = "Your First Name Can't More Than 20 Words.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name can't be null.")]
        [MaxLength(20, ErrorMessage = "Your Last Name Can't More Than 20 Words.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Salary can't be null..")]
        public int Salary { get; set; }
    }
}
