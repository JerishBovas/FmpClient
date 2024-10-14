namespace FmpClient.Models;

public class ShareFloat
{
    public required string Symbol { get; set; }
    public DateTime Date { get; set; }
    public decimal FreeFloat { get; set; }
    public long FloatShares { get; set; }
    public long OutstandingShares { get; set; }
    public string? Source { get; set; }
}