﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class CerealsController : Controller
    {
        public ICerealRepository ICerealRepository { get; }

        public CerealsController(ICerealRepository cerealRepository)
        {
            this.ICerealRepository = cerealRepository;
        }
        // GET: CerealsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CerealsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CerealsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CerealsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CerealsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CerealsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CerealsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CerealsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}