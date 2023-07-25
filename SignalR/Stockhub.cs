using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
	public class StockHub : Hub<IStockService>
	{
		public async Task SendStockPrice(string stockName, decimal price)
		{
			await Clients.All.SendStockPrice(stockName, price);
		}
	}
}