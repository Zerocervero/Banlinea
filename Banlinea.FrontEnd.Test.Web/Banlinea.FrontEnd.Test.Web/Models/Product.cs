namespace Banlinea.FrontEnd.Test.Web.Models
{
    public class Product : IBusinessEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public string ReferenceCode { get; set; }

        public ProductType ProductType { get; } = new ProductType();

        public ProductCategory Category { get; } = new ProductCategory();

        public string Tags { get; set; }
    }
}