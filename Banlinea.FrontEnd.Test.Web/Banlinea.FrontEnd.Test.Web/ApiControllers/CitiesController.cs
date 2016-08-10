using System.Collections.Generic;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class CitiesController : CustomApiControllerBase<City>
    {
        // GET: api/Cities
        public IEnumerable<City> Get()
        {
            return All();
        }

        // GET: api/Cities/5
        public City Get(int id)
        {
            return Find(id);
        }
    }
}