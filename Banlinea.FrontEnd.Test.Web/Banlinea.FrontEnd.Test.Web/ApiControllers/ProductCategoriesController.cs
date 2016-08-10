using System.Collections.Generic;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class ProductCategoriesController : CustomApiControllerBase<ProductCategory>
    {
        // GET: api/ProductCategories
        public IEnumerable<ProductCategory> Get()
        {
            return All();
        }

        // GET: api/ProductCategories/5
        public ProductCategory Get(int id)
        {
            return Find(id);
        }
    }
}