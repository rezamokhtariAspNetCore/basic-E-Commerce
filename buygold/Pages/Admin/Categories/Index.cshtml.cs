using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Admin.Categories;

public class IndexModel : PageModel
{
	private readonly IUnitOfWork _unitOfWork;

	public IEnumerable<Category> Categories { get; set; }

	public IndexModel(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public void OnGet()
	{
		Categories = _unitOfWork.Category.GetAll();
	}

}
