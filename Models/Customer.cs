using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
