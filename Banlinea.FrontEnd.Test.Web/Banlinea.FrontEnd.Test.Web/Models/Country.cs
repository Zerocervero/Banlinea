using System.Collections.Generic;

namespace Banlinea.FrontEnd.Test.Web.Models
{
    public class Country : IBusinessEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}