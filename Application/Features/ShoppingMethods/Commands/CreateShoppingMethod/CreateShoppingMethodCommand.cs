using Dtos.shoppingMethod;
using MediatR;

namespace Application.Features.ShoppingMethods.Commands.CreateShoppingMethod
{
    public class CreateShoppingMethodCommand:IRequest<ShopingMethodMinimalDTO>
    {
        //public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public CreateShoppingMethodCommand(string name, double price)
        {
           // Id = id;
            Name = name;
            Price = price;
        }
    }
}
