namespace SignalR
{
	public interface IStockService
	{
		Task SendStockPrice(string stockName, decimal price);
	}
}
