namespace FmpClient.Models;

public class Stock
{
    public required string Symbol { get; init; }
    public string? Name { get; init; }
    public decimal Price { get; init; }
    public double ChangesPercentage { get; init; }
    public double Change { get; init; }
    public decimal DayLow { get; init; }
    public decimal DayHigh { get; init; }
    public decimal YearHigh { get; init; }
    public decimal YearLow { get; init; }
    public long MarketCap { get; init; }
    public decimal PriceAvg50 { get; init; }
    public decimal PriceAvg200 { get; init; }
    public required string Exchange { get; init; }
    public long Volume { get; init; }
    public long AvgVolume { get; init; }
    public decimal Open { get; init; }
    public decimal PreviousClose { get; init; }
    public decimal? Eps { get; init; }
    public decimal? Pe { get; init; }
    public DateTime? EarningsAnnouncement { get; init; }
    public long SharesOutstanding { get; init; }
    public long Timestamp { get; init; }
}