using MediatR;
using OnlineStore.Contracts.ProductsDto;

namespace OnlineStore.AppServices.Mediator.Product.Commands
{
    public class AddProductCommand : IRequest
    {
        public ProductsDto _productDto { get; }

        public AddProductCommand(ProductsDto productDto)
        {
            _productDto = productDto;
        }
    }
}
