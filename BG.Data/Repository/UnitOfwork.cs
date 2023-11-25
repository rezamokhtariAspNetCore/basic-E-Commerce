using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;

namespace BG.Data.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly APDBCONX _db;
		public UnitOfWork(APDBCONX db)
		{
			_db = db;
			Category = new CategoryRepository(_db);
			GameType = new GameTypeRepository(_db);
			MenuItem = new MenuItemRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
			OrderDetail = new OrderDetailRepository(_db);
			OrderHeader = new OrderHeaderRepository(_db);
		}

		public ICategoryRepository Category { get; private set; }
		public IGameTypeRepository GameType { get; private set; }
		public IMenuItemRepository MenuItem { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
		public IOrderHeaderRepository OrderHeader { get; private set; }
		public IOrderDetailRepository OrderDetail { get; private set; }
		public IShoppingCartRepository ShoppingCart { get; private set; }

        public void Dispose()
		{
			_db.Dispose();
		}

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}