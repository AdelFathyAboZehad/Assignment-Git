using Application.Contracts;
using Dtos.shoppingMethod;
using MediatR;

namespace Application.Features.ShoppingMethods.Queries.GetShoppingMethodDetails
{
    public class GetShoppingMethodDetailsHandler:IRequestHandler<GetShoppingMethodDetailsQuery, ShopingMethodMinimalDTO >
    {
        private readonly IShoppingMethodRepository _shoppingMethodRepository;

        public GetShoppingMethodDetailsHandler(IShoppingMethodRepository shoppingMethodRepository)
        {
            _shoppingMethodRepository = shoppingMethodRepository;
        }

        public async Task<ShopingMethodMinimalDTO> Handle(GetShoppingMethodDetailsQuery request, CancellationToken cancellationToken)
        {
            var shopingMethod = await _shoppingMethodRepository.GetDetailsAsync(request.Id);
            if (shopingMethod != null)
            {
                return new ShopingMethodMinimalDTO(shopingMethod.Id, shopingMethod.Name, shopingMethod.Price);

            }
            else
            {
                throw new Exception("Not Found A Category");
            }

        }
    }
}
