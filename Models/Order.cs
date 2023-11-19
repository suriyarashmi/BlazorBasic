using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? ItemDescription { get; set; }
        public int Quantity { get; set; }
        public Customer? Customer { get; set; }
    }
}

