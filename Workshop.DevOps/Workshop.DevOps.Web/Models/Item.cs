using System.ComponentModel.DataAnnotations;

namespace Workshop.DevOps.Web.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Content { get; set; }
    }
}
