using System.Collections.Generic;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class ProductTypesController : CustomApiControllerBase<ProductType>
    {
        // GET: api/ProductTypes
        public IEnumerable<ProductType> Get()
        {
            return All();
        }

        // GET: api/ProductTypes/5
        public ProductType Get(int id)
        {
            return Find(id);
        }
    }
}