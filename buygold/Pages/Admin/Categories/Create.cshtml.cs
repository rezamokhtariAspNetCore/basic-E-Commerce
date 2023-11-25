

using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Admin.Categories;

[BindProperties]
public class CreateModel : PageModel
{
	private readonly IUnitOfWork _unitOfWork;

	public Category Category { get; set; }


	public CreateModel(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}
	public void OnGet()
	{
	}

	public async Task<IActionResult> OnPost()
	{
		if (Category.Name == Category.Author.ToString())
		{
			ModelState.AddModelError("Category.Name", "The Author cannot exactly match the Name.");
		}
		if (ModelState.IsValid)
		{
			_unitOfWork.Category.Add(Category);
			_unitOfWork.Save();
			TempData["success"] = "دسته بندی" ;
			return RedirectToPage("Index");
		}
		return Page();
	}
}
