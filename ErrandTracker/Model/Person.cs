using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandTracker.Model
{
    public enum Relationship
    {
        Mother,
        Father,
        Son,
        Daughter,
        GrandFather,
        GrandMother,
        Uncle,
        Aunt
    }

    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        public Relationship Relationship { get; set; }  
        
        public Email Email { get; set; }

        public Errand Errand { get; set; }
    }
}
