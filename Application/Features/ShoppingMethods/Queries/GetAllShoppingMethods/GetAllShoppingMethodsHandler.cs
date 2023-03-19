using Application.Contracts;
using Dtos.shoppingMethod;
using MediatR;

namespace Application.Features.ShoppingMethods.Queries.GetAllShoppingMethods
{
    public class GetAllShoppingMethodsHandler : IRequestHandler<GetAllShoppingMethodsQuery, IEnumerable<ShopingMethodMinimalDTO>>
    {
        private readonly IShoppingMethodRepository _shoppingMethodRepository;

        public GetAllShoppingMethodsHandler(IShoppingMethodRepository shoppingMethodRepository)
        {
            _shoppingMethodRepository = shoppingMethodRepository;
        }

        public async Task<IEnumerable<ShopingMethodMinimalDTO>> Handle(GetAllShoppingMethodsQuery request, CancellationToken cancellationToken)
        {
            return (await _shoppingMethodRepository.GetAllAsync()).Select(a => new ShopingMethodMinimalDTO(a.Id, a.Name, a.Price));

        }
    }
}
