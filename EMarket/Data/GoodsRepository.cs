using EMarket.Models;

namespace EMarket.Data
{
    public class GoodsRepository
    {
        private ApplicationDbContext _context;

        public GoodsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            var categories = _context.Categories.ToList();


            return categories;
        }
    }
}
