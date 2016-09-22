namespace ShopManager.Exceptions
{
    public class TooMuchDecrementionException : ShopException
    {
        public TooMuchDecrementionException(string message) : base(message)
        {
        }
    }
}