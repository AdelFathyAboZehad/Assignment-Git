using Application.Contracts;
using DbContextL;
using Domian;

namespace InfraStructure
{
    public class ShoppingMethodRepository : Repository<ShoppingMethod, int>, IShoppingMethodRepository
    {
        public ShoppingMethodRepository(Context context) : base(context)
        {

        }


    }
}
