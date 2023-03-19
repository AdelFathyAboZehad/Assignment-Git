using Application.Contracts;
using DbContextL;
using Domian;

namespace InfraStructure
{
    public class UserReviewRepository : Repository<UserReview, int>, IUserPaymetMethodRepository
    {
        public UserReviewRepository(Context context) : base(context)
        {

        }
    }

}
