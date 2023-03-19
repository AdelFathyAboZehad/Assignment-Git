using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian
{
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }
        [MaxLength(10)]
        
        public string? UnitNumber { get; set; }
        [MaxLength(100)]

        public string? StreetNumber { get; set; }
        [MaxLength(200),MinLength(5)]
        public string Address1 { get; set; }
        [MaxLength(200), MinLength(5)]
        public string? Address2 { get; set; }
        [MaxLength(100), MinLength(3)]
        public string City { get; set; }
        [MaxLength(50), MinLength(3)]
        public string Region { get; set; }
        [MaxLength(10), MinLength(5)]
        public string? PostCode { get; set; }
        [MaxLength(100), MinLength(5)]
        public string Country { get; set; }

        //relation with UserAddresses

        public IEnumerable <UserAddress> UserAddresses { get; set; }
        //relation with Order

        public  IEnumerable<Order>? Orders { get; set; }

        public Address( string address1,  string city, string region, string country, string? address2=null, string? postCode=null, string? unitNumber=null, string? streetNumber=null)
        {
            UnitNumber = unitNumber;
            StreetNumber = streetNumber;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Region = region;
            PostCode = postCode;
            Country = country;
            UserAddresses = new List<UserAddress>();
            Orders = new List<Order>();
        }

        public Address():this (null!,null!, null!, null!) 
        { 
        }
    }
}
