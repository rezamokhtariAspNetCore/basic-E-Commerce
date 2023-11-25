using BG.Model;

namespace BG.Data.Repository.IRepository
{
	public interface IGameTypeRepository : IRepository<GameType>
	{
		void Update(GameType obj);
	}
}
