using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandTracker.Model
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }
       
        [Required]
        public string EmailAddress { get; set; }
       
        //one to one mapping by convention
        public Person Person { get; set; }
        
        public int PersonId { get; set; }
    }
}
