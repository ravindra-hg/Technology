using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myApiService.Controllers
{
	public class OrdersController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<Order> Get()
		{
			return new List<Order>() { 
				new Order() { Id = 1, Qty = 10, TotalCost = 100m },
				new Order() { Id = 2, Qty = 20, TotalCost = 200m },
			};
		}

		// GET api/<controller>/5
		public Order Get(int id)
		{
			return new Order() { Id = id, Qty = 10, TotalCost = 100m };
		}

		// POST api/<controller>
		public void Post([FromBody]Order order)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]Order order)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}