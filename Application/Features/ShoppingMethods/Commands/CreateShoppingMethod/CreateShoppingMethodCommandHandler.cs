using Application.Contracts;
using Domian;
using Dtos.shoppingMethod;
using MediatR;


namespace Application.Features.ShoppingMethods.Commands.CreateShoppingMethod
{
    public class CreateShoppingMethodCommandHandler : IRequestHandler<CreateShoppingMethodCommand, ShopingMethodMinimalDTO>
    {
        private readonly IShoppingMethodRepository _shoppingMethodRepository;

        public CreateShoppingMethodCommandHandler(IShoppingMethodRepository shoppingMethodRepository)
        {
            _shoppingMethodRepository = shoppingMethodRepository;
        }
        public async Task<ShopingMethodMinimalDTO> Handle(CreateShoppingMethodCommand request, CancellationToken cancellationToken)
        {
            User user = new User();

            ShoppingMethod shoppingMethod = new ShoppingMethod(request.Name, (decimal)request.Price);
            await _shoppingMethodRepository.CreateAsync(shoppingMethod);


            if (shoppingMethod != null)
            {
                return new ShopingMethodMinimalDTO(shoppingMethod.Id, shoppingMethod.Name, shoppingMethod.Price);
            }
            else
            {
                throw new Exception("can not create a shopingmethod");
            }
        }
    }
}
