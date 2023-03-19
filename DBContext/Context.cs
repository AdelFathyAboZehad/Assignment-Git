using Domian;
using Microsoft.EntityFrameworkCore;
namespace DbContextL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
      
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<UserPaymetMethod> UserPaymetMethods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingMethod> ShoppingMethods { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<VariationOption> VariationOptions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Stock> Stocks { get; set; }




    }
}
