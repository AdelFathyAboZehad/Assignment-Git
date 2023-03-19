using Application.Contracts;
using MediatR;

namespace Application.Features.ShoppingMethods.Commands.DeleteShoppingMethod
{
    public class DeleteShoppingMethodCommandHandler : IRequestHandler<DeleteShoppingMethodCommand, bool>
    {
        private readonly IShoppingMethodRepository _shoppingMethodRepository;

        public DeleteShoppingMethodCommandHandler(IShoppingMethodRepository shoppingMethodRepository)
        {
            _shoppingMethodRepository = shoppingMethodRepository;
        }
        public async Task<bool> Handle(DeleteShoppingMethodCommand request, CancellationToken cancellationToken)
        {
            return (await _shoppingMethodRepository.DeleteAsync(request.id));
        }
    }
}
