using System.Net;
using System.Web.Mvc;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.Controllers
{
    public class ProductsController : CustomControllerBase<Product>
    {
        // GET: Products
        public ActionResult Index()
        {
            return View(All());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Photo,Description,ReferenceCode,Tags")] Product product)
        {
            if (!ModelState.IsValid) return View(product);
            Add(product);
            return RedirectToAction("Index");
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Photo,Description,ReferenceCode,Tags")] Product product)
        {
            if (!ModelState.IsValid) return View(product);
            Update(product);
            return RedirectToAction("Index");
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drop(id);
            return RedirectToAction("Index");
        }
    }
}