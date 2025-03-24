namespace Catalog.API.Models
{
    public class Product
    {
        // As a primary key in databases(instead of an int ID).
        public Guid Id { get; set; }
        // ! - Trust me, this wont be null
        public string Name { get; set; } = default!;
        public List<string> Category { get; set; } = new();
        public string Description { get; set; } = default!;
        public string ImageFile { get; set; } = default!;
        public decimal Price { get; set; }

    }
}
