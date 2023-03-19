using Domian;

namespace Application.Contracts
{
    public interface IShoppingMethodRepository : IRepository<ShoppingMethod, int>
    {
        // Task<IEnumerable<ShoppingMethod>> GetAllAsync();
    }
}
