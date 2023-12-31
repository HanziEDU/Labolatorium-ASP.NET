﻿using Labolatorium3___app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3___app.Controllers
{
    public class ContactController : Controller
    {
       private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model) 
        {
            if (ModelState.IsValid)
            {
                _contactService.add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id) 
        {
            return View(_contactService.FindByID(id));
        }
        [HttpPost]
        public IActionResult Update(Contact model) 
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            return View(_contactService.FindByID(id));
        }
        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.RemoveByID(model.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id) 
        {
            return View(_contactService.FindByID(id));
        }
    }
}
