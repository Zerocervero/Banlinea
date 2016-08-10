using System.Net;
using System.Web.Mvc;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.Controllers
{
    public class EnterprisesController : CustomControllerBase<Enterprise>
    {
        // GET: Enterprises/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enterprises/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,EnterpriseType")] Enterprise enterprise)
        {
            if (!ModelState.IsValid) return View(enterprise);
            Add(enterprise);
            return RedirectToAction("Index");
        }

        // GET: Enterprises/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var enterprise = Find(id);
            if (enterprise == null)
            {
                return HttpNotFound();
            }
            return View(enterprise);
        }

        // POST: Enterprises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drop(id);
            return RedirectToAction("Index");
        }

        // GET: Enterprises/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var enterprise = Find(id);
            if (enterprise == null)
            {
                return HttpNotFound();
            }
            return View(enterprise);
        }

        // GET: Enterprises/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var enterprise = Find(id);
            if (enterprise == null)
            {
                return HttpNotFound();
            }
            return View(enterprise);
        }

        // POST: Enterprises/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,EnterpriseType")] Enterprise enterprise)
        {
            if (!ModelState.IsValid) return View(enterprise);
            Update(enterprise);
            return RedirectToAction("Index");
        }

        // GET: Enterprises
        public ActionResult Index()
        {
            return View(All());
        }
    }
}