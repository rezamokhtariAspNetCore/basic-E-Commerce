using BG.Data.DATA;
using BG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Data.Repository.IRepository
{
	public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
	{
		private readonly APDBCONX _db;

		public OrderHeaderRepository(APDBCONX db) : base(db)
		{
			_db = db;
		}

		public void Update(OrderHeader obj)
		{
			_db.OrderHeader.Update(obj);
		}

		public void UpdateStatus(int id, string status)
		{
			var orderFromDb = _db.OrderHeader.FirstOrDefault(u => u.Id == id);
			if (orderFromDb != null)
			{
				orderFromDb.Status = status;
			}
		}
	}
}
