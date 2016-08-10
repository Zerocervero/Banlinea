using System.Collections.Generic;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class UsersController : CustomApiControllerBase<User>
    {
        // GET: api/Users
        public IEnumerable<User> Get()
        {
            return All();
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return Find(id);
        }
    }
}