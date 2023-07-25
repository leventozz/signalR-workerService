using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
	public class StockHub : Hub
	{
		public async Task SendStockPrice(string stockName, decimal price)
		{
			await Clients.Others.SendAsync("ReceiveStockPrice",stockName, price);
		}
	}
}