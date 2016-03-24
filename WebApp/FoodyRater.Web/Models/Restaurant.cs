using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodyRater.Web.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public virtual List<Category> Categories { get; set; }

        public virtual List<Position> Positions { get; set; }
    }
}
