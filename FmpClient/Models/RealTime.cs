namespace FmpClient.Models;

public class RealTime
{
    public required string Symbol { get; set; }

    public decimal PrevClose { get; set; }

    public decimal High { get; set; }

    public decimal Low { get; set; }

    public decimal Open { get; set; }

    public long Volume { get; set; }

    public decimal LastSalePrice { get; set; }

    public decimal FmpLast { get; set; }

    public DateTime LastUpdated { get; set; }
}