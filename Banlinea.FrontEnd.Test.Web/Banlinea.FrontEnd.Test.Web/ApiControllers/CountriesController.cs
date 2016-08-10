using System.Collections.Generic;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class CountriesController : CustomApiControllerBase<Country>
    {
        // GET: api/Countries
        public IEnumerable<Country> Get()
        {
            return All();
        }

        // GET: api/Countries/5
        public Country Get(int id)
        {
            return Find(id);
        }
    }
}