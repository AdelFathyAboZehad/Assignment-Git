using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian
{
    [Table("Role")]
    public class Role
    {

        public int Id { get; set; }
        [MaxLength(200), MinLength(3)]
        public string Name { get; set; }
        //relation with user
        public IEnumerable<User>? Users { get; set; }

        public Role(string name)
        {
            Name = name;
            Users = new List<User>();

        }

        public Role() : this(null!)
        {

        }
    }
}
