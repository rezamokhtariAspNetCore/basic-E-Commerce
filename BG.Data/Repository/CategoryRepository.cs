using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;

namespace BG.Data.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		private readonly APDBCONX _db;

		public CategoryRepository(APDBCONX db) : base(db)
		{
			_db = db;
		}

		public void Update(Category category)
		{
			var objFromDb = _db.Category.FirstOrDefault(u => u.Id == category.Id);
			objFromDb.Name = category.Name;
			objFromDb.Author = category.Author;
		}
	}
}
