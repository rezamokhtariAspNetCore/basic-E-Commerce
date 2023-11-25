using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Client.Home
{
    public class IndexModel : PageModel
    {
		private readonly IUnitOfWork _unitOfWork;
		public IndexModel(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<MenuItem> MenuItemsList { get; set; }
		public IEnumerable<Category> CategoryList { get; set; }

		public void OnGet()
        {
			MenuItemsList = _unitOfWork.MenuItem.GetAll(includeProperties: "Category,GameType");
			CategoryList = _unitOfWork.Category.GetAll();
		}
    }
}
