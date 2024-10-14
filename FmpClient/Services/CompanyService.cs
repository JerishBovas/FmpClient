using System.Net;
using FmpClient.IServices;
using FmpClient.Models;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace FmpClient.Services;

public class CompanyService(ILogger<CompanyService> logger, IRestClient restClient) : ICompanyService
{
    public async Task<Result<List<Company>>> GetCompanyProfile(string symbol)
    {
        return await FetchData<List<Company>>($"v3/profile/{symbol}");
    }

    public async Task GetExecutiveCompensation()
    {
        throw new NotImplementedException();
    }

    public async Task GetCompensationBenchmark()
    {
        throw new NotImplementedException();
    }

    public async Task GetCompanyNotes()
    {
        throw new NotImplementedException();
    }

    public async Task GetHistoricalEmployee()
    {
        throw new NotImplementedException();
    }

    public async Task GetEmployeeCount()
    {
        throw new NotImplementedException();
    }

    public async Task GetScreener()
    {
        throw new NotImplementedException();
    }

    public async Task GetStockGrade()
    {
        throw new NotImplementedException();
    }

    public async Task GetExecutives()
    {
        throw new NotImplementedException();
    }

    public async Task GetCoreInfo()
    {
        throw new NotImplementedException();
    }

    public async Task GetMarketCap()
    {
        throw new NotImplementedException();
    }

    public async Task GetHistoricalMarketCap()
    {
        throw new NotImplementedException();
    }

    public async Task GetAllCountries()
    {
        throw new NotImplementedException();
    }

    public async Task GetAnalystEstimates()
    {
        throw new NotImplementedException();
    }

    public async Task GetAnalystRecommendation()
    {
        throw new NotImplementedException();
    }

    public async Task GetCompanyLogo()
    {
        throw new NotImplementedException();
    }

    public async Task GetCompanyOutlook()
    {
        throw new NotImplementedException();
    }

    public async Task GetStockPeers()
    {
        throw new NotImplementedException();
    }

    public async Task GetTradingHours(string exchange)
    {
        throw new NotImplementedException();
    }

    public async Task GetAllExchangeTradingHours()
    {
        throw new NotImplementedException();
    }

    public async Task GetDelistedCompanies()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<List<ShareFloat>>> GetCompanyShareFloat()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<List<ShareFloat>>> GetHistoricalShareFloat()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<List<ShareFloat>>> GetAllShareFloat()
    {
        return await FetchData<List<ShareFloat>>("v4/shares_float/all");
    }

    public async Task<Result<List<string>>> GetAllAvailableSectors()
    {
        return await FetchData<List<string>>("v3/sectors-list");
    }

    public async Task<Result<List<string>>> GetAllAvailableIndustries()
    {
        return await FetchData<List<string>>("v3/industries-list");
    }

    public async Task<Result<List<string>>> GetAllAvailableExchanges()
    {
        return await FetchData<List<string>>("v3/exchanges-list");
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