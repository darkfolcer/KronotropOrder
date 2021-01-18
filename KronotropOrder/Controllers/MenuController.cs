using KronotropOrder.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KronotropOrder.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService, ILogger<MenuController> logger)
        {
            _menuService = menuService;
        }

        [HttpGet]
        [Route("api/menu/get")]
        public JsonResult Get()
        {
           return Json(_menuService.GetMenu());
        }  
    }
}
