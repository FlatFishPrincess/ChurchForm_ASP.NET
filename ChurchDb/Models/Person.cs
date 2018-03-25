using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChurchDb.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public String LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public String FirstName { get; set; }

        public String Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

    }
}
    