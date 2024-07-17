using Shared.Wrappers;

using System.Globalization;

namespace Shared.Exceptions;

public class ApiException : Exception
{
    public ApiResponse.Error Error { get; set; }
    public ApiException() : base()
    {
    }

    public ApiException(string message) : base(message)
    {
    }

    public ApiException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args))
    {
    }
}