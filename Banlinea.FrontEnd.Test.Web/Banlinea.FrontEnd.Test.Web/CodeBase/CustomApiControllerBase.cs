using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.CodeBase
{
    public abstract class CustomApiControllerBase<TEntity> : ApiController, IRequiresSessionState
        where TEntity : IBusinessEntity
    {
        private HttpSessionState Session => HttpContext.Current.Session;

        private ICollection<TEntity> ContextData
        {
            get
            {
                if (Session[ContextSessionName] == null)
                {
                    Session[ContextSessionName] = new List<TEntity>();
                }
                return (ICollection<TEntity>)Session[ContextSessionName];
            }
        }

        private static string ContextSessionName => $"Admin{typeof(TEntity).Name}";

        protected IEnumerable<TEntity> All()
        {
            return ContextData;
        }

        protected TEntity Find(int? id)
        {
            var entity = ContextData.First(e => e.Id == id);
            return entity;
        }
    }
}