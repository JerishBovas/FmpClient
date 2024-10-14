namespace FmpClient.Models;

public class Quote
{
    public required string Symbol { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public double ChangesPercentage { get; set; }
    public double Change { get; set; }
    public decimal DayLow { get; set; }
    public decimal DayHigh { get; set; }
    public decimal YearHigh { get; set; }
    public decimal YearLow { get; set; }
    public long MarketCap { get; set; }
    public decimal PriceAvg50 { get; set; }
    public decimal PriceAvg200 { get; set; }
    public required string Exchange { get; set; }
    public long Volume { get; set; }
    public long AvgVolume { get; set; }
    public decimal Open { get; set; }
    public decimal PreviousClose { get; set; }
    public double Eps { get; set; }
    public double Pe { get; set; }
    public DateTime EarningsAnnouncement { get; set; }
    public long SharesOutstanding { get; set; }
    public long Timestamp { get; set; }
}