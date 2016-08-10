using System.Collections.Generic;

namespace Banlinea.FrontEnd.Test.Web.Models
{
    public class Enterprise : IBusinessEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Country Country { get; } = new Country();

        public EnterpriseType EnterpriseType { get; set; }

        public User Owner { get; set; }

        public ICollection<Product> Products { get; } = new List<Product>();
    }
}