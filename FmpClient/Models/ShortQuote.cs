namespace FmpClient.Models;

public class ShortQuote
{
    public string Symbol { get; set; }
    
    public decimal Price { get; set; }
    
    public long Volume { get; set; }
}