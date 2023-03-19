using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian
{
    [Table("User")]
    public class User
    {
        public long Id { get; set; }

        [MaxLength(100), MinLength(3)]
        public string Fname { get; set; }
        [MaxLength(100), MinLength(3)]
        public string Lname { get; set; }
        [MaxLength(200), MinLength(3), RegularExpression(@"[A-Za-z]+")]

        public string UserName { get; set; }
        [DataType(DataType.EmailAddress), RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$")]
        public string Email { get; set; }
        [MaxLength(50), Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,}$")]
        public string Password { get; set; }

        [MaxLength(100), DataType(DataType.Password)]
        public string ComfirmPassword { get; set; }
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        //collection of UserReviews 
        public IEnumerable<UserReview>? UserReviews { get; set; }

        //relation with user
        public IEnumerable<Role> Roles { get; set; }
        //relation with UserPaymetMethods

        public IEnumerable<UserPaymetMethod>? UserPaymetMethods { get; set; }
        //relation with Cart

        public IEnumerable<Cart>? Carts { get; set; }



        //collection of Orders 
        // public virtual ICollection<Order> Orders { get; set; }

        //relation with UserAddresses

        public IEnumerable<UserAddress>? UserAddresses { get; set; }

        public User(string fname, string lname, string userName, string email, string password, string comfirmPassword, string phoneNumber)
        {

            Fname = fname;
            Lname = lname;
            UserName = userName;
            Email = email;
            Password = password;
            ComfirmPassword = comfirmPassword;
            PhoneNumber = phoneNumber;
            UserReviews = new List<UserReview>();
            Roles = new List<Role>();
            UserPaymetMethods = new List<UserPaymetMethod>();
            Carts = new List<Cart>();
            UserAddresses = new List<UserAddress>();

        }



        public User() : this(null!, null!, null!, null!, null!, null!, null!)
        {


        }
    }
}
