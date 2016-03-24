using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodyRater.Web.Models
{
    public class Position
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Rating> Ratings { get; set; }
    }
}