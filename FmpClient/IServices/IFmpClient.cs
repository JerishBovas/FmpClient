namespace FmpClient.IServices;

public interface IFmpClient
{
    public IStockService Stocks { get; }

    public ICompanyService Companies { get; set; }

    public IQuoteService Quotes { get; set; }
}