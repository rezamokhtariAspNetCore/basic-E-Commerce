using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Admin.Categories;

[BindProperties]
public class EditModel : PageModel
{
	private readonly IUnitOfWork _unitOfWork;

	public Category Category { get; set; }


	public EditModel(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public void OnGet(int id)
	{
		Category = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
		//Category = _db.Category.FirstOrDefault(u=>u.Id==id);
		//Category = _db.Category.SingleOrDefault(u=>u.Id==id);
		//Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
	}

	public async Task<IActionResult> OnPost()
	{
		if (Category.Name == Category.Author.ToString())
		{
			ModelState.AddModelError("Category.Name", "The Author cannot exactly match the Name.");
		}
		if (ModelState.IsValid)
		{
			_unitOfWork.Category.Update(Category);
			_unitOfWork.Save();
			TempData["info"] = "دسته بندی شما بروز شد";
			return RedirectToPage("Index");
		}
		return Page();
	}
}
