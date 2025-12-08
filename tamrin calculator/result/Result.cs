namespace ResulPattern; 

public struct Result<T>
{
    public T Value { get; }
    public bool IsSuccess { get; }
    public bool IsFailure { get => !IsSuccess; }

    private Result(T value, bool isSuccess)
    {
        Value = value;
        IsSuccess = isSuccess;
    }
    public static Result<T> Success(T value) => new Result<T>(value, true);
    public static Result<T> Failure() => new Result<T>(default(T)!, false);
}
