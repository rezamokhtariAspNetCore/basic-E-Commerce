using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;

namespace BG.Data.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly APDBCONX _db;

        public ShoppingCartRepository(APDBCONX db) : base(db)
        {
            _db= db;
        }

		public int DecrementCount(ShoppingCart shoppingCart, int count)
		{
			shoppingCart.Count -= count;
			_db.SaveChanges();
			return shoppingCart.Count;
		}

		public int IncrementCount(ShoppingCart shoppingCart, int count)
		{
			shoppingCart.Count += count;
			_db.SaveChanges();
			return shoppingCart.Count;
		}
	}
}
