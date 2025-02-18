namespace FmpClient.Models;

public class Company
{
    public required string Symbol { get; set; }
    public decimal Price { get; set; }
    public decimal Beta { get; set; }
    public long VolAvg { get; set; }
    public long MktCap { get; set; }
    public decimal LastDiv { get; set; }
    public string Range { get; set; }
    public decimal Changes { get; set; }
    public required string CompanyName { get; set; }
    public required string Currency { get; set; }
    public string Cik { get; set; }
    public string Isin { get; set; }
    public string Cusip { get; set; }
    public string Exchange { get; set; }
    public string ExchangeShortName { get; set; }
    public string Industry { get; set; }
    public string Website { get; set; }
    public string Description { get; set; }
    public string Ceo { get; set; }
    public string Sector { get; set; }
    public string Country { get; set; }
    public string FullTimeEmployees { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public decimal DcfDiff { get; set; }
    public decimal Dcf { get; set; }
    public string Image { get; set; }
    public DateTime IpoDate { get; set; }
    public bool DefaultImage { get; set; }
    public bool IsEtf { get; set; }
    public bool IsActivelyTrading { get; set; }
    public bool IsAdr { get; set; }
    public bool IsFund { get; set; }
}