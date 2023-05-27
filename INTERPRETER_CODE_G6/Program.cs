using Antlr4.Runtime;
using INTERPRETER_CODE_G6;
using INTERPRETER_CODE_G6.Exceptions;
using INTERPRETER_CODE_G6.Grammar;

var contents =
    File.ReadAllText(
        "C:\\Users\\JMARK\\Git Repositories\\Programming Language Interpreter\\INTERPRETER_CODE_G6\\INTERPRETER_CODE_G6\\TestFiles\\infinite.txt");
var program = contents.Trim();
var inputStream = new AntlrInputStream(program);
var codeLexer = new CodeLexer(inputStream);
codeLexer.RemoveErrorListeners();
codeLexer.AddErrorListener(new MyErrorListener());
var commonTokenStream = new CommonTokenStream(codeLexer);
var codeParser = new CodeParser(commonTokenStream);
codeParser.RemoveErrorListeners();
codeParser.AddErrorListener(new MyErrorParser());
var startAst = codeParser.program();
var visitor = new Code();

visitor.Visit(startAst);