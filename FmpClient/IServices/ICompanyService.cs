using FmpClient.Models;

namespace FmpClient.IServices;

public interface ICompanyService
{
    public Task<Result<List<Company>>> GetCompanyProfile(string symbol);

    public Task GetExecutiveCompensation();

    public Task GetCompensationBenchmark();

    public Task GetCompanyNotes();

    public Task GetHistoricalEmployee();

    public Task GetEmployeeCount();

    public Task GetScreener();

    public Task GetStockGrade();

    public Task GetExecutives();

    public Task GetCoreInfo();

    public Task GetMarketCap();
    
    public Task GetHistoricalMarketCap();

    public Task GetAllCountries();

    public Task GetAnalystEstimates();

    public Task GetAnalystRecommendation();

    public Task GetCompanyLogo();

    public Task GetCompanyOutlook();

    public Task GetStockPeers();

    public Task GetTradingHours(string exchange);

    public Task GetAllExchangeTradingHours();

    public Task GetDelistedCompanies();

    public Task<Result<List<ShareFloat>>> GetCompanyShareFloat();
    
    public Task<Result<List<ShareFloat>>> GetHistoricalShareFloat();

    public Task<Result<List<ShareFloat>>> GetAllShareFloat();

    public Task<Result<List<string>>> GetAllAvailableSectors();
    
    public Task<Result<List<string>>> GetAllAvailableIndustries();
    
    public Task<Result<List<string>>> GetAllAvailableExchanges();
}