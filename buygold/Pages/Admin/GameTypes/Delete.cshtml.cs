using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Admin.GameTypes;

[BindProperties]
public class DeleteModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public GameType GameType { get; set; }


    public DeleteModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public void OnGet(int id)
    {
        GameType = _unitOfWork.GameType.GetFirstOrDefault(u => u.Id == id);
        //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
        //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
        //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
    }

    public async Task<IActionResult> OnPost()
    {
        var gameTypeFromDb = _unitOfWork.GameType.GetFirstOrDefault(u => u.Id == GameType.Id);
        if (gameTypeFromDb != null)
        {
            _unitOfWork.GameType.Remove(gameTypeFromDb);
            _unitOfWork.Save();
            TempData["success"] = "نوع بازی شما حذف شد";
            return RedirectToPage("Index");

        }

        return Page();
    }
}
