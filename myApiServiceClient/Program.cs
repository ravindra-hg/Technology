using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace myApiServiceClient
{
	class Program
	{
		static void Main(string[] args)
		{
			GetOrders();
			Console.ReadLine();
		}

		public static void GetOrders()
		{
			using (HttpClient httpClient = new HttpClient())
			{
				httpClient.BaseAddress = new Uri("http://localhost/myApiService/");
				string serviceUrl = "api/Orders";
				httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
				HttpResponseMessage response = httpClient.GetAsync(serviceUrl).Result;
				if (response.IsSuccessStatusCode)
				{
					var orders = response.Content.ReadAsAsync<IEnumerable<Order>>();
					foreach (var item in orders.Result)
					{
						Console.WriteLine("Id:{0}, Qty:{1}, TotalCost:{2}", item.Id, item.Qty, item.TotalCost);
					}

				}
				else
				{
					Console.WriteLine("Error : {0}", response.StatusCode);
				}

			}
		}
	}
}
