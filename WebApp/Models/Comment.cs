using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Comment
    {
        public int ID { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateAt { get; set; }
    }
}