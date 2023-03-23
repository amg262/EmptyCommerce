using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCommerce
{
    public class EmptyPageController : PageController<EmptyPage>
    {
        [HttpGet]
        public IActionResult Index(EmptyPage currentPage)
        {
            return View(currentPage);
        }
    }
}