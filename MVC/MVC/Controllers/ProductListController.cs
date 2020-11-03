using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProductListController : Controller
    {
        CatProEntities1 db = new CatProEntities1();
        //
        // GET: /ProductList/

        public ActionResult Index()
        {
            var query = from p in db.Products
                        join c in db.Categories on p.CatId equals c.CategoryId

                        select new ProductWithCategory { Product = p, Category = c };
            var model = query.ToList();
            return View(model);
        }

    }
}
