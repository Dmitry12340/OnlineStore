using MediatR;
using OnlineStore.AppServices.Mediator.Product.Commands;
using OnlineStore.AppServices.Product.Repositories;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Mediator.Product.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IProductRepository _productRepository;
        public AddProductCommandHandler(IProductRepository repository)
        {
            _productRepository = repository;
        }
        public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            List<ProductImages> productImages = new List<ProductImages>();
            foreach (var image in request._productDto.Images)
            {
                productImages.Add(new ProductImages { Path = image });
            }

            var product = new Products
            {
                Name = request._productDto.Name,
                Category = request._productDto.Category,
                Description = request._productDto.Description,
                Price = request._productDto.Price,
                Quantity = request._productDto.Quantity,
                Images = productImages
            };
            await _productRepository.AddAsync(product);
        }
    }
}
