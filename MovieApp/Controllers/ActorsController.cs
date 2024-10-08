﻿using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();
            return View();
        }
    }
}
