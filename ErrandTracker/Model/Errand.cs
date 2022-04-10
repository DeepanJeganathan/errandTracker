using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandTracker.Model
{
    public class Errand
    {
        [Key]
        public int ErrandId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get { return IsCompleted; } set { value = false; } }
        public DateTime CompleteByDate { get; set; }
        public DateTime StartDate { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
