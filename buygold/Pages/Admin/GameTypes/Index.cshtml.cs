using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buygold.Pages.Admin.GameTypes;

public class IndexModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public IEnumerable<GameType> GameTypes { get; set; }

    public IndexModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public void OnGet()
    {
        GameTypes = _unitOfWork.GameType.GetAll();
    }
}
