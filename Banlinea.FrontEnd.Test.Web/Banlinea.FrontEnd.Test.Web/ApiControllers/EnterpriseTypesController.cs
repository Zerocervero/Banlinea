using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.ApiControllers
{
    public class EnterpriseTypesController : ApiController
    {
        // GET: api/EnterpriseTypes
        public IEnumerable<dynamic> Get()
        {
            var dict = Enum.GetNames(typeof(EnterpriseType)).ToDictionary(name => (int)Enum.Parse(typeof(EnterpriseType), name));
            return dict.Select(d => new { Id = d.Key, Value = d.Value });
        }
    }
}