using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myApiService.Controllers
{
	public class Order
	{
		public int Id { get; set; }
		public int Qty { get; set; }
		public decimal TotalCost { get; set; }
	}
}
