using System.ComponentModel.DataAnnotations.Schema;

namespace EMarket.Models
{
    public class Goods
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public required string ImgUrl { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public DateTime Created { get; set; }

    }
}
