using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    //Kada korisnik pošalje HTTP POST zahtev da kreira proizvod, API prima podatke u ovom formatu.
    //Koristi se u CQRS paternu
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) 
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    //internal se koristi da bi rekli da je klasa dostupna samo u ovom projektu(assembly)
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Business logic to create a product
            //Steps
            //1.Create Product entity from command object
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,
            };


            //2.save to database


            //3.return CreateProductResult result
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
