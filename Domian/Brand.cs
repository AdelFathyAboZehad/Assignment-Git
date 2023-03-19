using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian
{
    [Table("Brand")]
    public class Brand
    {

        public int Id { get; set; }
        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }
        //private readonly IList<Product> _products;
        public IEnumerable<Product> Products { get; set; }
        public Brand(string brandName)
        {
            Name = brandName;
            Products = new List<Product>(); ;
        }
        private Brand() : this(null!) { }
        //public bool AddProduct(Product product)
        //{

        //    var checkProductName = Products.FirstOrDefault(a => a.Name == product.Name);
        //    if (checkProductName != null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        _products.Add(product);
        //        return true;
        //    }
        //}
    }
}
