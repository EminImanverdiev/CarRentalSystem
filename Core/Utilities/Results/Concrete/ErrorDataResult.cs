namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(message, false, data)
        {

        }
        public ErrorDataResult(T data) : base(false, data)
        {

        }
        public ErrorDataResult(string message) : base(message, false, default)
        {

        }
        public ErrorDataResult() : base(false, default)
        {

        }
    }

}
