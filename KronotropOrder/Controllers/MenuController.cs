using KronotropOrder.Products.Interfaces;
using KronotropOrder.Products.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KronotropOrder.Controllers
{
    public class MenuController : Controller
    {
        private readonly IBeverageService _beverageService;
        private readonly IAdditionService _additionService;
        Menu _menu { get; set; }

        public MenuController(IAdditionService additionService, IBeverageService beverageService, ILogger<MenuController> logger)
        {
            _beverageService = beverageService;
            _additionService = additionService;
            _menu = new Menu();
            _menu.Additions = _additionService.GetAll();
            _menu.Beverages = _beverageService.GetAll();

        }

        [HttpGet]
        [Route("api/menu/get")]
        public JsonResult Get()
        {
           return Json(_menu);
        }

        [HttpGet]
        [Route("api/menu/add/beverage")]
        public JsonResult AddNewBeverageToMenu(int _Id, string _Name)
        {
            _menu.Beverages = _beverageService.Add(new Beverage { Id = _Id, Name = _Name });
            return Json(_menu);
        }
        [HttpGet]
        [Route("api/menu/add/addition")]
        public JsonResult AddNewAdditionToMenu(int _Id, string _Name)
        {
            _menu.Additions = _additionService.Add(new Addition { Id = _Id, Name = _Name });
            return Json(_menu);
        }
    }
}
