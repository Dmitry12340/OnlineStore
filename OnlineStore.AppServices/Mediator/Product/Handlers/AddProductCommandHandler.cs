using MediatR;
using OnlineStore.AppServices.Mediator.Product.Commands;
using OnlineStore.AppServices.Product.Repositories;
using OnlineStore.AppServices.Product.Services;

namespace OnlineStore.AppServices.Mediator.Product.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IProductService _productService;
        public AddProductCommandHandler(IProductRepository repository, IProductService productService)
        {
            _productService = productService;
        }
        public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.AddAsync(request._productDto);
        }
    }
}
