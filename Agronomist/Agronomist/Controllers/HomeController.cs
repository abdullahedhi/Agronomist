using Agronomist.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Agronomist.Controllers
{
    public class HomeController : Controller
    {
        private DBAgronomistEntities1 db = new DBAgronomistEntities1();
        //
        // GET: /Home/

        public ActionResult Index()
        {


            return View("Index");
        }


       

       
        public ActionResult Login()
        {
           /* string query = "SELECT FirstName, LastName "
        + "FROM mvcUser";
            IEnumerable<Agronomist.mvcUser> data = db.Database.SqlQuery<Agronomist.mvcUser>(query);*/

            return View();
       }

        public ActionResult MyAccount()
        {
            return View();
        }

                public ActionResult Buyerprofile()
                {
                    return View();
                }

     
        public ActionResult Register()
        {
            return View(db.mvcUsers.ToList());
        }

         //
        // GET: /Data/Details/5

        public ActionResult Details(string id = null)
        {
            mvcUser mvcuser = db.mvcUsers.Find(id);
            if (mvcuser == null)
            {
                return HttpNotFound();
            }
            return View(mvcuser);
        }

        //
        // GET: /Data/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Data/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mvcUser mvcuser)
        {
            if (ModelState.IsValid)
            {
                db.mvcUsers.Add(mvcuser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mvcuser);
        }

        //
        // GET: /Data/Edit/5

        public ActionResult Edit(string id = null)
        {
            mvcUser mvcuser = db.mvcUsers.Find(id);
            if (mvcuser == null)
            {
                return HttpNotFound();
            }
            return View(mvcuser);
        }

        //
        // POST: /Data/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(mvcUser mvcuser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mvcuser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mvcuser);
        }

        //
        // GET: /Data/Delete/5

        public ActionResult Delete(string id = null)
        {
            mvcUser mvcuser = db.mvcUsers.Find(id);
            if (mvcuser == null)
            {
                return HttpNotFound();
            }
            return View(mvcuser);
        }

        //
        // POST: /Data/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            mvcUser mvcuser = db.mvcUsers.Find(id);
            db.mvcUsers.Remove(mvcuser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }

    }


       

    
