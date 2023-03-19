using Application.Contracts;
using DbContextL;
using Domian;

namespace InfraStructure
{
    public class UserPaymetMethodRepository : Repository<UserPaymetMethod, int>, IUserPaymetMethodRepository
    {
        public UserPaymetMethodRepository(Context context) : base(context)
        {

        }


    }
}
