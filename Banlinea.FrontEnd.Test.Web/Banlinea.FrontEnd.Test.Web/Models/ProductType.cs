namespace Banlinea.FrontEnd.Test.Web.Models
{
    public class ProductType : IBusinessEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}