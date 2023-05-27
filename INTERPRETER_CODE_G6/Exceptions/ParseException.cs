namespace INTERPRETER_CODE_G6.Exceptions;

public class ParseException : Exception
{
    public ParseException(string message) : base(message) { }

    public ParseException(string message, Exception innerException) : base(message, innerException){}
}