using Antlr4.Runtime;

namespace INTERPRETER_CODE_G6.Exceptions;

public class ParserException: BaseErrorListener
{
    public static readonly ParserException Instance = new ParserException();
    
    public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        throw new ParseException($"line {line}:{charPositionInLine} {msg}");
    }

    /*public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        throw new ParseException($"line {line}:{charPositionInLine} {msg}");
    }*/
}