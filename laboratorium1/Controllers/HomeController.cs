﻿using laboratorium1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laboratorium1.Controllers
{
    public enum Operators
    {
        Add, Sub, Mul, Div
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About(string author, int? id)
        {
            //string author = Request.Query["author"];
            //string strid = Request.Query["id"];
            //if (int.TryParse(strid, out var id))
            //{
            //    ViewBag.Author = author + " id = " + id;
            //}
            if (id == null || author == null)
            {
                return BadRequest();
            }
            ViewBag.Author = author + " id = " + id;
            return View();
        }


        public IActionResult Calculator([FromQuery(Name = "operator")] Operators? op, double? x, double? y)
        {
            if (op == null || x == null || y == null)
            {
                BadRequest();
            }
            string r = "";
            switch (op)
            {
                case Operators.Add:
                    r = $"{x} + {y} = {x + y}";
                    break;
                case Operators.Sub:
                    r = $"{x} - {y} = {x - y}";
                    break;
                case Operators.Mul:
                    r = $"{x} * {y} = {x * y}";
                    break;
                case Operators.Div:
                    r = $"{x} / {y} = {x / y}";
                    break;
            }
            ViewBag.op = op;
         return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}