﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
