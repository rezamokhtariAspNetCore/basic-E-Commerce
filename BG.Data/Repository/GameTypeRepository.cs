using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;

namespace BG.Data.Repository
{
	public class GameTypeRepository : Repository<GameType>, IGameTypeRepository
	{
		private readonly APDBCONX _db;
		public GameTypeRepository(APDBCONX db) : base(db)
		{
			_db = db;
		}
		public void Update(GameType obj)
		{
			var objFromDb = _db.GameType.FirstOrDefault(u => u.Id == obj.Id);
			objFromDb.Name = obj.Name;
		}
	}
}
