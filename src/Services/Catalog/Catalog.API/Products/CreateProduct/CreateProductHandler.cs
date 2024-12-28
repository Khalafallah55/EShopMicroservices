
using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductComamnd(string Name , List<string> Category , string Description , string ImageFile, decimal Price)
        :ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductComamnd, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductComamnd command, CancellationToken cancellationToken)
        {
            //create product entity from command object
            // save to database 
            // return CreateProductResult resuly 
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //return result
            return new CreateProductResult(Guid.NewGuid());

        }
    }
}
