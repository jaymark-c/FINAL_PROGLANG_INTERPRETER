using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Sharpen;

namespace INTERPRETER_CODE_G6.Exceptions;

public class LexerException :  BaseErrorListener, IAntlrErrorListener<int>
{
    public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        var errorMessage = $"Syntax Error: line {line}:{charPositionInLine} {msg}";
        Environment.Exit(1);
        //throw new ParseException(errorMessage);
    }

    public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        var errorMessage = $"Syntax Error: line {line}:{charPositionInLine} {msg}";
        Environment.Exit(1);
        //throw new ParseException(errorMessage);
    }
    
    public override void ReportAmbiguity(Parser recognizer, DFA dfa, int startIndex, int stopIndex, bool exact, BitSet ambigAlts, ATNConfigSet configs)
    {
        var errorMessage = $"Ambiguity Error: line {recognizer.Context.Start.Line}:{recognizer.Context.Start.Column} Cannot decide which alternative to choose at line {startIndex}:{stopIndex}";
        Environment.Exit(1);
        //throw new ParseException(errorMessage);
    }
    /*public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        // Handle the lexer error here
        Console.Error.WriteLine($"Lexer error: {msg} at line {line}, position {charPositionInLine}");

        // Exit the application
        Environment.Exit(1);
    }*/
}