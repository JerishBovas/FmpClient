using FmpClient.Models;

namespace FmpClient.IServices;

public interface IStockService
{
    public Task<Result<List<ShortStock>>> GetStocks();

    public Task<Result<List<ShortStock>>> GetEtfs();

    public Task<Result<List<string>>> GetStatementSymbols();

    public Task<Result<List<ShortStock>>> GetActivelyTradedStocks();

    public Task GetCommitmentOfTradersReports();

    public Task GetCikList();

    public Task GetEuronetSymbols();

    public Task GetSymbolChanges();

    public Task<Result<List<Stock>>> GetExchangeSymbols(string exchange);

    public Task GetAvailableIndexes();
}