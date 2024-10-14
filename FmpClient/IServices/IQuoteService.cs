using FmpClient.Models;

namespace FmpClient.IServices;

public interface IQuoteService
{
    public Task<Result<List<Quote>>> GetFullQuote(string symbol);

    public Task<Result<List<Quote>>> GetQuoteOrder(string symbol);
    
    public Task<Result<List<ShortQuote>>> GetSimpleQuote(string symbol);
    
    public Task<Result<List<RealTime>>> GetOTCQuote(string symbol);
    
    public Task<Result<List<Quote>>> GetAllExchangeQuotes(string exchange);
    
    public Task<Result<List<RealTime>>> GetRealTimeQuote(string symbol);
    
    public Task<Result<List<RealTime>>> GetAllRealTimeQuotes();
}