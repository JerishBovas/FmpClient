using System.Net;
using Microsoft.Extensions.Logging;
using RestSharp;
using FmpClient.IServices;
using FmpClient.Models;

namespace FmpClient.Services;

public class StockService(ILogger<StockService> logger, IRestClient restClient) : IStockService
{
    public async Task<Result<List<ShortStock>>> GetStocks()
    {
        return await FetchData<List<ShortStock>>("v3/stock/list");
    }

    public async Task<Result<List<ShortStock>>> GetEtfs()
    {
        return await FetchData<List<ShortStock>>("v3/etf/list");
    }

    public async Task<Result<List<string>>> GetStatementSymbols()
    {
        return await FetchData<List<string>>("v3/financial-statement-symbol-lists");
    }
    
    public async Task<Result<List<ShortStock>>> GetActivelyTradedStocks()
    {
        return await FetchData<List<ShortStock>>("v3/available-traded/list");
    }

    public Task GetCommitmentOfTradersReports()
    {
        throw new NotImplementedException();
    }

    public Task GetCikList()
    {
        throw new NotImplementedException();
    }

    public Task GetEuronetSymbols()
    {
        throw new NotImplementedException();
    }

    public Task GetSymbolChanges()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<List<Stock>>> GetExchangeSymbols(string symbol)
    {
        return await FetchData<List<Stock>>($"v3/symbol/{symbol}");
    }

    public Task GetAvailableIndexes()
    {
        throw new NotImplementedException();
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