using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Database.Entities
{

    public enum PersonGender
    {
        [Display(Name = "Male")] MALE,
        [Display(Name = "Female")] FEMALE,
        [Display(Name = "I would rather not tell")] NOT_SPECIFIED
    }

    public class PersonEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        [Required]
        public PersonGender Gender { get; set; }
        [Required]
        public DateTimeOffset RegistrationDate { get; set; } = DateTimeOffset.UtcNow;

        public PersonEntity()
        {
        }

        public PersonEntity(string firstName, string lastName, PersonGender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

    }
}
