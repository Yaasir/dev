﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        FoodDb _db = new FoodDb();

        //
        // GET: /Reviews/

        public ActionResult Index()
        {
            var model = _db.Reviews.FindTheLatest(3);
            return View(model); //model
        }

        //
        // GET: /Reviews/Details/5

        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var model = _db.Reviews.FindTheBest();
            return PartialView("_Review", model);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Reviews/Edit/5
 
        public ActionResult Edit(int id)
        {
            var review = _db.Reviews.FindById(id);
            return View(review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _db.Reviews.FindById(id);
            //try
            //{
            //    // TODO: Add update logic here            
            //    TryUpdateModel(review);
            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View(review);
            //}

            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            return View(review);

        }

        //
        // GET: /Reviews/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

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
