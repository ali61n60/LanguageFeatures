﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Model;

namespace LanguageFeatures.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
            //page 107 in the book
        }
    }
}
