using System.Net;
using FmpClient.IServices;
using FmpClient.Models;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace FmpClient.Services;

public class QuoteService(ILogger<QuoteService> logger, IRestClient restClient) : IQuoteService
{
    public async Task<Result<List<Quote>>> GetFullQuote(string symbol)
    {
        return await FetchData<List<Quote>>($"v3/quote/{symbol}");
    }

    public async Task<Result<List<Quote>>> GetQuoteOrder(string symbol)
    {
        return await FetchData<List<Quote>>($"v3/quote-order/{symbol}");
    }

    public async Task<Result<List<ShortQuote>>> GetSimpleQuote(string symbol)
    {
        return await FetchData<List<ShortQuote>>($"v3/quote-short/{symbol}");
    }

    public async Task<Result<List<RealTime>>> GetOTCQuote(string symbol)
    {
        return await FetchData<List<RealTime>>($"v3/otc/real-time-price/{symbol}");
    }

    public async Task<Result<List<Quote>>> GetAllExchangeQuotes(string exchange)
    {
        return await FetchData<List<Quote>>($"v3/quotes/{exchange}");
    }

    public async Task<Result<List<RealTime>>> GetRealTimeQuote(string symbol)
    {
        return await FetchData<List<RealTime>>($"v3/stock/full/real-time-price/{symbol}");
    }

    public async Task<Result<List<RealTime>>> GetAllRealTimeQuotes()
    {
        return await FetchData<List<RealTime>>("v3/stock/full/real-time-price");
    }
    
    private async Task<Result<T>> FetchData<T>(string url)
    {
        var request = new RestRequest(url);
        var response = await restClient.ExecuteAsync<T>(request);

        if (response.StatusCode == HttpStatusCode.OK)
            return response.Data == null
                ? Result<T>.Failure("Empty response")
                : Result<T>.Success(response.Data);
        
        return Result<T>.Failure(response.Content ?? "");
    }
}