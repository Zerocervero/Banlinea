using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.CodeBase
{
    public abstract class CustomControllerBase<TEntity> : Controller
        where TEntity : IBusinessEntity
    {
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

        private int GetNextId
        {
            get
            {
                if (Session[ContextSessionIdName] == null)
                {
                    Session[ContextSessionIdName] = default(int);
                }
                else
                {
                    Session[ContextSessionIdName] = (int)Session[ContextSessionIdName] + 1;
                }
                return (int)Session[ContextSessionIdName];
            }
        }

        private static string ContextSessionName => $"Admin{typeof(TEntity).Name}";

        private static string ContextSessionIdName => $"{typeof(TEntity).Name}Id";

        protected IEnumerable<TEntity> All()
        {
            return ContextData;
        }

        protected void Add(TEntity entity)
        {
            if (entity.Id.Equals(default(int)))
            {
                entity.Id = GetNextId;
            }
            ContextData.Add(entity);
        }

        protected void Drop(TEntity entity)
        {
            ContextData.Remove(entity);
        }

        protected void Drop(int? id)
        {
            var entity = Find(id);
            Drop(entity);
        }

        protected TEntity Find(int? id)
        {
            var entity = ContextData.First(e => e.Id == id);
            return entity;
        }

        protected void Update(TEntity entity)
        {
            var foundEntity = Find(entity.Id);
            ContextData.Remove(foundEntity);
            Add(entity);
        }
    }
}