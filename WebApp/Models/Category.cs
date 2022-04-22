using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public List<News> News { get; set; }
    }
}