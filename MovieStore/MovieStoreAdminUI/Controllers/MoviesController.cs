﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieShopGateway;
using MovieStoreDAL;



namespace MovieStoreUI.Controllers
{
    public class MoviesController : Controller
    {
        
        Facade facade = new Facade();
        

        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movies = (List<Movie>) facade.GetMovieGatewayService().ReadAll();
            return View(movies);
           
         
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {

            Movie movie = facade.GetMovieGatewayService().Read(id);
            //Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Year,Price,ImageUrl,TrailerUrl,Genre")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                facade.GetMovieGatewayService().Add(movie);

                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {

            Movie movie = facade.GetMovieGatewayService().Read(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Year,Price,ImageUrl,TrailerUrl,Genre")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                facade.GetMovieGatewayService().Update(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {

            Movie movie = facade.GetMovieGatewayService().Delete(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //POST: Movies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {

            facade.GetMovieGatewayService().Delete(id);


            return RedirectToAction("Index");
        }


    }
}
