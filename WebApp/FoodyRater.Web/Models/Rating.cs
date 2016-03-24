using System.ComponentModel.DataAnnotations.Schema;

namespace FoodyRater.Web.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int Score { get; set; }

        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}