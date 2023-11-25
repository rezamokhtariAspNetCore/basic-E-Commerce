﻿using BG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Data.Repository.IRepository
{
	public interface IOrderDetailRepository : IRepository<OrderDetails>
	{
		void Update(OrderDetails obj);

	}
}
