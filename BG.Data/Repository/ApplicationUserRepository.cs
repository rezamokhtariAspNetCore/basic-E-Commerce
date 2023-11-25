using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;

namespace BG.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly APDBCONX _db;

        public ApplicationUserRepository(APDBCONX db) : base(db)
        {
            _db= db;
        }
        
    }
}
