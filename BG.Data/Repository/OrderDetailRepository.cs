using BG.Data.DATA;
using BG.Data.Repository.IRepository;
using BG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Data.Repository
{
	public class OrderDetailRepository : Repository<OrderDetails>, IOrderDetailRepository
	{
		private readonly APDBCONX _db;

		public OrderDetailRepository(APDBCONX db) : base(db)
		{
			_db = db;
		}

		public void Update(OrderDetails obj)
		{
			_db.OrderDetails.Update(obj);
		}
	}
}
