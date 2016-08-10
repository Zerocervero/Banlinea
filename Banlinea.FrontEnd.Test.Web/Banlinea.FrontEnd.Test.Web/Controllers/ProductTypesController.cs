﻿using System.Net;
using System.Web.Mvc;
using Banlinea.FrontEnd.Test.Web.CodeBase;
using Banlinea.FrontEnd.Test.Web.Models;

namespace Banlinea.FrontEnd.Test.Web.Controllers
{
    public class ProductTypesController : CustomControllerBase<ProductType>
    {
        // GET: ProductTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductTypes/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] ProductType productType)
        {
            if (!ModelState.IsValid) return View(productType);
            Add(productType);
            return RedirectToAction("Index");
        }

        // GET: ProductTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var productType = Find(id);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // POST: ProductTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drop(id);
            return RedirectToAction("Index");
        }

        // GET: ProductTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var productType = Find(id);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // GET: ProductTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var productType = Find(id);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // POST: ProductTypes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] ProductType productType)
        {
            if (!ModelState.IsValid) return View(productType);
            Update(productType);
            return RedirectToAction("Index");
        }

        // GET: ProductTypes
        public ActionResult Index()
        {
            return View(All());
        }
    }
}