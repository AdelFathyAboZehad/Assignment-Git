﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }
        //selfRelation

        public Category? Parentcategory { get; set; }

        //private IList<Category> subCategories;
        public IEnumerable<Category> SubCategories { get; set; }

        //Relation for Product
        //private readonly IList<Product> products;
        public IEnumerable<Product> Products { get; set; }

        //public Category(string name, Category? parentcategory = null)
        //{

        //    Name = name;
        //    Parentcategory = parentcategory;

        //}




        public Category(string name, Category? parentcategory)
        {
            Name = name;
            Parentcategory = parentcategory;
            SubCategories = new List<Category>();
            Products = new List<Product>();



        }
        private Category() : this(null!, null) { }

        //public bool AddSubCategory(Category SubCategory)
        //{
        //    var ISCategoryNull = SubCategories.FirstOrDefault(x => x.Name == SubCategory.Name);
        //    if (ISCategoryNull == null)
        //    {
        //        subCategories.Add(SubCategory);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool AddProduct(Product product)
        //{
        //    var ISProductNull = products.FirstOrDefault(x => x.Name == product.Name);
        //    if (ISProductNull == null)
        //    {
        //        products.Add(product);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
