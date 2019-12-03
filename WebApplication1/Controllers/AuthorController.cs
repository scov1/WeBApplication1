using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author

        [HandleError]
        public ActionResult Index()
        {
            var model = AuthorRepo.List();
            if (Request.IsAjaxRequest())
            {
                return PartialView("AuthorPartialView", model);
            }
            return View(model);
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //// GET: Author/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Author/Create
        [HttpPost]
        [FilterHelper]
        public ActionResult Create(Author collection)
        {
            ReturnEx(collection.Id);
                // TODO: Add insert logic here
                AuthorRepo.Create(collection);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("AuthorPartialView", collection);
                }

                return RedirectToAction("Index");
        }

        private void ReturnEx(int id)
        {
            int zero = 0;
            var temp = id / zero;
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
