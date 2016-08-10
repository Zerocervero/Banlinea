using System.Collections.Generic;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class ProductsController : CustomApiControllerBase<Product>
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return All();
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return Find(id);
        }
    }
}