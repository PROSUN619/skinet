
namespace Core.Entities
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; } // add foreign key relationship with ID
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; } // add foreign key relationship with ID
        public int ProductBrandId { get; set; }               
    }
}