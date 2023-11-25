using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Admin.GameTypes;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public GameType GameType { get; set; }


    public CreateModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {
      
        if (ModelState.IsValid)
        {
            _unitOfWork.GameType.Add(GameType); 
            _unitOfWork.Save();
            TempData["success"] = "نوع بازی شما ساخته شد";
            return RedirectToPage("Index");
        }
        return Page();
    }
}
