using Application.Contracts;
using DbContextL;
using Domian;

namespace InfraStructure
{
    public class CartRepository : Repository<Cart, int>, ICartRepository
    {
        public CartRepository(Context context) : base(context)
        {

        }


    }
}
