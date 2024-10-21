using System.ComponentModel.DataAnnotations;

namespace OrtizHansEjercicioPractico.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        [Required]
        public string? BurgerName { get; set; }

        public bool WithCheese { get; set; }
        [Range(0.1,99.99)]
        public double Price { get; set; }
        public List<Promo>? Promos { get; set; }
    }
}
