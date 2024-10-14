namespace FmpClient.Models;

public class Result<T>
{
    public T Data { get; private set; }
    public bool IsSuccess { get; private set; }
    public string Error { get; private set; }

    private Result(T data)
    {
        Data = data;
        IsSuccess = true;
    }

    private Result(string error)
    {
        Error = error;
        IsSuccess = false;
    }

    public static Result<T> Success(T data) => new Result<T>(data);
    public static Result<T> Failure(string error) => new Result<T>(error);
}