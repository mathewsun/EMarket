using EMarket.Data;
using Microsoft.AspNetCore.Mvc;

namespace EMarket.Controllers
{
    public class GoodsController : Controller
    {
        private GoodsRepository _goodsRepository;

        public GoodsController(GoodsRepository goodsRepository) 
        {
            _goodsRepository = goodsRepository;
        }

        public IActionResult Index()
        {
            var categories = _goodsRepository.GetAllCategories();

            return View(categories);
        }
    }
}
