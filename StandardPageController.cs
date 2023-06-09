﻿using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCommerce
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}