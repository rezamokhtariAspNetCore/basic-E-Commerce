using BG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Data.Repository.IRepository
{
	public interface IMenuItemRepository : IRepository<MenuItem>
	{
		void Update(MenuItem obj);
	}
}
