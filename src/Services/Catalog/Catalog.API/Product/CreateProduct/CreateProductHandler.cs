using MediatR;

namespace Catalog.API.Product.CreateProduct
{

    public record CreateProdudctCommand(string Name, List<string> Category, string Description, string ImagePath, decimal Price)
        :IRequest<CreateProductResult>;
    public record CreateProductResult(Guid id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProdudctCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProdudctCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
