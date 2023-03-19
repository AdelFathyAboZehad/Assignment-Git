using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian
{
    [Table("Image")]
    public class Image
    {
        public long Id { get; set; }
        [MaxLength(500)]
        public string ImageURL { get; set; }
        public Product Product { get; set; }
        public Image(string imageUrl, Product product)
        {
            ImageURL = imageUrl;
            Product = product;
        }
        private Image() : this(null!, null!) { }


    }
}
