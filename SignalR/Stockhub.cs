using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
	public class StockHub : Hub
	{
		public async Task SendStockPrice(string stockName, decimal price)
		{
			await Clients.All.SendAsync("ReceiveStockPrice",stockName, price);
		}
	}
}