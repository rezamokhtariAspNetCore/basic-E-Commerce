using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;

namespace BG.Data.Repository
{
	public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
	{
		private readonly APDBCONX _db;

		public MenuItemRepository(APDBCONX db) : base(db)
		{
			_db = db;
		}


		public void Update(MenuItem obj)
		{
			var objFromDb = _db.MenuItem.FirstOrDefault(u => u.Id == obj.Id);
			objFromDb.Name = obj.Name;
			objFromDb.Description = obj.Description;
			objFromDb.Price = obj.Price;
			objFromDb.CategoryId = obj.CategoryId;
			objFromDb.GameTypeId = obj.GameTypeId;
			if (objFromDb.Image != null)
			{
				objFromDb.Image = obj.Image;
			}

		}
	}
}
