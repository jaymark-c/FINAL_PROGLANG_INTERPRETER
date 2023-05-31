using INTERPRETER_CODE_G6.Grammar;

namespace INTERPRETER_CODE_G6;
public class Code : CodeBaseVisitor<object?>
{
    /// <summary>
    /// Helper functions for OPERATION purposes
    /// </summary>
    private readonly HelperFunctions _hf = new HelperFunctions();
    /// <summary>
    /// A dictionary for data variables
    /// </summary>
    private Dictionary<string, object?> ColonCall { get; } = new();
    private Dictionary<string, object?> CharacterIdentifier { get; } = new();
    private Dictionary<string, object?> IntegerIdentifier { get; } = new();
    private Dictionary<string, object?> FloatIdentifier { get; } = new();
    private Dictionary<string, object?> BooleanIdentifier { get; } = new();

    /// <summary>
    /// Call the function on constructor
    /// </summary>
    public Code()
    {
        ColonCall["DISPLAY"] = new Func<object?[], object?>(Display);
        ColonCall["SCAN"] = new Func<object?[], object?>(Scan);
    }

    /// <summary>
    /// Calls Scan function and assign a variable
    /// </summary>
    /// <param name="arrItems">Array of variables to scan</param>
    /// <returns>none</returns>
    private object? Scan(object?[] arrItems)
    {
        Console.Write("\n");
        Console.Write("SCAN: ");
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
        }
        var userInputIdentifiers = userInput!.Split(',');
        int varcnt = 0;
        if (userInputIdentifiers.Length != arrItems.Length)
        {
            Console.WriteLine("SCAN length format is incorrect");
            Environment.Exit(1);
        }
        foreach (var arrItem in arrItems)
        {
            if (CharacterIdentifier.ContainsKey(arrItem!.ToString()!))
            {
                try
                {
                    var convInput = Convert.ToChar(userInputIdentifiers[varcnt]);
                    CharacterIdentifier[arrItem.ToString()!] = convInput;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error data type expects another");
                    Environment.Exit(1);
                }
                
            }else if (IntegerIdentifier.ContainsKey(arrItem!.ToString()!))
            {
                try
                {
                    var convInput = Convert.ToInt32(userInputIdentifiers[varcnt]);
                    IntegerIdentifier[arrItem.ToString()!] = convInput;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error data type expects another");
                    Environment.Exit(1);
                }
                
            }else if (FloatIdentifier.ContainsKey(arrItem!.ToString()!))
            {
                try
                {
                    var convInput = float.Parse(userInputIdentifiers[varcnt]);
                    FloatIdentifier[arrItem.ToString()!] = convInput;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error data type expects another");
                    Environment.Exit(1);
                }
                
            }else if (BooleanIdentifier.ContainsKey(arrItem!.ToString()!))
            {
                try
                {
                    var convInput = userInputIdentifiers[varcnt];

                    if (convInput is "TRUE" or "FALSE")
                    {
                        if (convInput == "TRUE")
                            BooleanIdentifier[arrItem.ToString()!] = true;
                        else
                            BooleanIdentifier[arrItem.ToString()!] = false;
                    }
                    else
                    {
                        Console.WriteLine("Cannot recognize \"TRUE\" or \"FALSE\" value");
                        Environment.Exit(1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error data type expects another");
                }
            }
            else
            {
                Console.WriteLine("Identifier is not declared in the system");
                Environment.Exit(1);
            }
            varcnt++;
        }  
        return null;
    }

    /// <summary>
    /// Calls Display function and print variables value
    /// </summary>
    /// <param name="arrItems">Array of variables to print</param>
    /// <returns>none</returns>
    private object? Display(object?[] arrItems)
    {
        foreach (var arrItem in arrItems)
        {
            if (arrItem is null)
            {
                Console.WriteLine("Error no value initialized");
                Environment.Exit(1);   
            }else if (arrItem is bool)
            {
                if(arrItem is true)
                    Console.Write("TRUE");
                else
                    Console.Write("FALSE");
            }else
                Console.Write(arrItem);
        }
        return null;
    }

    /// <summary>
    /// Calls DISPLAY: || SCAN: function 
    /// </summary>
    /// <param name="context"></param>
    /// <returns>none</returns>
    public override object? VisitColonFunc(CodeParser.ColonFuncContext context)
    {
        if (context.COLONFUNCTION().ToString() == "DISPLAY")
        {
            var cfname = context.COLONFUNCTION().GetText();
            var express = context.expression().Select(Visit).ToArray();
            //Console.WriteLine(express[0].GetType());
            if (express.Length == 0)
            {
                Console.WriteLine("No value/s received");
                Environment.Exit(1);   
            }

            if (ColonCall[cfname] is not Func<object?[], object?> func)
            {
                Console.WriteLine($"{cfname}: is not a valid function");
                Environment.Exit(1);  
            }
            else
            {
                return func(express);
            }

            return null;
        }
        else
        {
            var cfname = context.COLONFUNCTION().GetText();
            var express = context.expression().Select(Visit).ToArray();

            if (express.Length == 0)
            {
                Console.WriteLine($"No value/s received on scan");
                Environment.Exit(1);   
            }

            if (ColonCall[cfname] is not Func<object?[], object?> func)
            {
                Console.WriteLine($"{cfname}: is not a valid function");
                Environment.Exit(1);
            }
            else
            {
                return func(express);
            }

            return null;
        }
    }

    /// <summary>
    /// Initialize declarations
    /// </summary>
    /// <param name="context"></param>
    /// <returns>none</returns>
    public override object? VisitTerminalDeclaration(CodeParser.TerminalDeclarationContext context)
    {
        var dataType = context.parent.parent.GetChild(0).GetText();
        if (context.GetText().Contains('='))
        {
            InitializeMain(dataType, context.IDENTIFIER().ToString()!, Visit(context.expression()), false);
            return null;
        }
        InitializeMain(dataType, context.IDENTIFIER().ToString()!, null, true);
        return null;
    }

    /// <summary>
    /// Visit each declarations -> terminalDeclaration
    /// </summary>
    /// <param name="context"></param>
    /// <returns>none</returns>
    public override object? VisitDeclarations(CodeParser.DeclarationsContext context)
    {
        foreach (var s in context.children)
        {
            Visit(s);
        }
        return null;
    }

    /// <summary>
    /// Visit declarations
    /// </summary>
    /// <param name="context"></param>
    /// <returns>none</returns>
    public override object? VisitDeclaration(CodeParser.DeclarationContext context)
    {
        if (context.equalDeclaration() != null)
        {
            var dataType = context.DATATYPE().GetText();
            var arrVar = context.equalDeclaration().GetText().Split("=");
            var varValue = arrVar[arrVar!.Length - 1];
            for (int i = 0; i < arrVar.Length - 1; i++)
            {
                switch (dataType)
                {
                    case "INT":
                        if (IntegerIdentifier.ContainsKey(arrVar[i]))
                        {
                            Console.WriteLine("Identifier already declare");
                        }

                        IntegerIdentifier[arrVar[i]] = int.Parse(varValue);
                        break;
                    case "BOOL":
                        if (BooleanIdentifier.ContainsKey(arrVar[i]))
                        {
                            Console.WriteLine("Identifier already declare");
                        }
                        
                        if (varValue == "\"TRUE\"")
                            BooleanIdentifier[arrVar[i]] = true;
                        else
                            BooleanIdentifier[arrVar[i]] = false;
                        break;
                    case "CHAR":
                        if (CharacterIdentifier.ContainsKey(arrVar[i]))
                        {
                            Console.WriteLine("Identifier already declare");
                        }

                        CharacterIdentifier[arrVar[i]] = char.Parse(varValue);
                        break;
                    case "FLOAT":
                        if (FloatIdentifier.ContainsKey(arrVar[i]))
                        {
                            Console.WriteLine("Identifier already declare");
                        }
                        FloatIdentifier[arrVar[i]] = float.Parse(varValue);
                        break;
                }
            }
            /*foreach (var s in arrVar)
            {
                switch (dataType)
                {
                    case "INT":
                        if (IntegerIdentifier.ContainsKey(s))
                        {
                            Console.WriteLine("Identifier already declare");
                        }

                        IntegerIdentifier[s] = int.Parse(varValue);
                        break;
                    case "BOOL":
                        if (BooleanIdentifier.ContainsKey(s))
                        {
                            Console.WriteLine("Identifier already declare");
                        }
                        if(varValue == "\"TRUE\"")
                            BooleanIdentifier[s] = true;
                        else
                            BooleanIdentifier[s] = false;
                        break;
                    case "CHAR":
                        if (CharacterIdentifier.ContainsKey(s))
                        {
                            Console.WriteLine("Identifier already declare");
                        }
                        CharacterIdentifier[s] = char.Parse(varValue);
                        break;
                    case "FLOAT":
                        if (FloatIdentifier.ContainsKey(s))
                        {
                            Console.WriteLine("Identifier already declare");
                        }
                        FloatIdentifier[s] = float.Parse(varValue);
                        break;
                }
            }*/
        }
        else
        {
            Visit(context.declarations());
        }
        return null;
    }
    
    /// <summary>
    /// Reads Identifier
    /// </summary>
    /// <param name="context"></param>
    /// <returns>if SCAN returns identifier || others will return its value</returns>
    public override object? VisitIdentifierExpression(CodeParser.IdentifierExpressionContext context)
    {
        var identifier = context.IDENTIFIER().GetText();
        if (context.parent.GetChild(0).ToString() == "SCAN")
        {
            return identifier;
        }
        //check main
        if (CharacterIdentifier.TryGetValue(identifier, out var visitIdentifierExpression2))
        {
            return visitIdentifierExpression2;
        }
        if (IntegerIdentifier.TryGetValue(identifier, out var expression3))
        {
            return expression3;
        }
        if (FloatIdentifier.TryGetValue(identifier, out var identifierExpression3))
        {
            return identifierExpression3;
        }
        if (BooleanIdentifier.TryGetValue(identifier, out var visitIdentifierExpression3))
        {
            //Console.WriteLine(visitIdentifierExpression3.GetType());
            if (visitIdentifierExpression3!.ToString() == "True")
                return "TRUE";
            return "FALSE";
            //return visitIdentifierExpression3;
        }
        Console.WriteLine($"Variable {identifier} is not defined");
        Environment.Exit(1);
        return null;
    }
    
    /// <summary>
    /// Initializes variable
    /// </summary>
    /// <param name="dataType"></param>
    /// <param name="identifierName"></param>
    /// <param name="identifierValue"></param>
    /// <param name="shouldNull"></param>
    private void InitializeMain(string dataType, string identifierName, object? identifierValue, bool shouldNull)
    {
        switch (dataType)
        {
            case "CHAR":
                if (!shouldNull)
                {
                    if (identifierValue is not char)
                    {
                        Console.WriteLine("Not a CHAR");
                        Environment.Exit(1);
                    }
                }
                CharacterIdentifier[identifierName] = identifierValue;
                break;
            case "INT":
                if (!shouldNull)
                {
                    if (identifierValue is not int)
                    {
                        Console.WriteLine("Not an INT");
                        Environment.Exit(1);
                    }
                }
                IntegerIdentifier[identifierName] = identifierValue;
                break;
            case "FLOAT":
                if (!shouldNull)
                {
                    //Console.WriteLine(identifierValue.GetType().ToString() == "System.Single");
                    if (identifierValue is not float && identifierValue is not int)
                    {
                        Console.WriteLine("Not a FLOAT");
                        Environment.Exit(1);
                    }
                }
                FloatIdentifier[identifierName] = identifierValue;
                break;
            case "BOOL":
                
                if (!shouldNull)
                {
                    if (!(identifierValue!.Equals(true)|| identifierValue.Equals(false)))
                    {
                        Console.WriteLine("Not a boolean");
                        Environment.Exit(1);
                    }
                }
                BooleanIdentifier[identifierName] = identifierValue;
                break;
        }
    }

    /// <summary>
    /// Assigns a value to an identifier
    /// </summary>
    /// <param name="context"></param>
    /// <returns>null</returns>
    public override object? VisitAssignment(CodeParser.AssignmentContext context)
    {
        //x = -x
        var varUnarySign = context.GetChild(2).GetText();
        var identifierName = context.assignments().GetText();
        var express = Visit(context.expression());
        var identifierSplit = identifierName!.Split('=');
        foreach (var identItem in identifierSplit)
        {
            if (CharacterIdentifier.ContainsKey(identItem))
            {
                //if (value is string | value is char)
                //if (express is string | express is char)
                if (express is char)
                {
                    if (varUnarySign == "-" | varUnarySign == "+" || express!.ToString()!.Length > 1)
                    {
                        Console.WriteLine($"Expected a char value: {varUnarySign}");
                        Environment.Exit(1);
                    }
                    CharacterIdentifier[identItem] = express;
                }
                else
                {
                    Console.WriteLine($"Error assignment for identifier {identifierName}: expected to be CHAR");
                    Environment.Exit(1);
                }
            }
            else if (IntegerIdentifier.ContainsKey(identItem))
            {
                if (express is int i)
                {
                    if (varUnarySign == "-")
                    { 
                        IntegerIdentifier[identItem] = -1 * i;
                    }else
                        IntegerIdentifier[identItem] = i;
                }
                else
                {
                    Console.WriteLine($"Error assignment for identifier {identifierName} : expected to be INT");
                    Environment.Exit(1);
                }
            }
            else if (FloatIdentifier.ContainsKey(identItem))
            {
                if (express is float f)
                {
                    if (varUnarySign == "-")
                        FloatIdentifier[identItem] = -1.0 * f;
                    else
                        FloatIdentifier[identItem] = f;
                }else if (express is int i)
                {
                    if (varUnarySign == "-")
                        FloatIdentifier[identItem] = -1.0 * i;
                    else
                        FloatIdentifier[identItem] = i * 1.0;
                }
                else
                {
                    Console.WriteLine($"Error assignment for identifier {identifierName}: expected to be FLOAT");
                    Environment.Exit(1);
                }
            }
            else if (BooleanIdentifier.ContainsKey(identItem))
            {
                //if (express is "TRUE" or "FALSE")
                if (express is bool)
                {
                    if (varUnarySign == "=" | varUnarySign == "+")
                    {
                        Console.WriteLine($"Error unary sign in a bool");
                        Environment.Exit(1);
                    }
                    BooleanIdentifier[identItem] = express;
                }
                else
                {
                    Console.WriteLine($"Error assignment for identifier {identifierName}: expected to be BOOL");
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine($"Error identifier {identItem} is not recognize.");
                Environment.Exit(1);
            }
        }
        return null; 
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitConstant(CodeParser.ConstantContext context)
    {
        if (context.INTEGERLITERAL() != null)
        {
            return int.Parse(context.parent.GetText());
        }

        if (context.FLOATLITERAL() != null)
        {
            return float.Parse(context.parent.GetText());
        }

        if (context.CHARLITERAL() is { } c)
        {
            return char.Parse(c.GetText()[1..^1]);
        }

        if (context.BOOLEANLITERAL() != null)
        {
            return context.BOOLEANLITERAL().GetText()[1..^1] == "TRUE";
        }

        if (context.STRINGLITERAL() is { } s)
        {
            return s.GetText()[1..^1];
        }
        return null;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitNewLineExpression(CodeParser.NewLineExpressionContext context)
    {
        return context.DOLLARSIGNCARRIAGE() != null ? "\n" : null;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitConcatenateExpression(CodeParser.ConcatenateExpressionContext context)
    {
        if (Visit(context.expression(0)) == null || Visit(context.expression(1)) == null)
        {
            Console.WriteLine("Error accessing null values");
            Environment.Exit(1);
        } 
        return Visit(context.expression(0))! + Visit(context.expression(1))!.ToString();
    }
   
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    private static object? VisitErrorCaller(string message)
    {
        Console.WriteLine(message);
        Environment.Exit(1);
        return null;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitBinaryExpression(CodeParser.BinaryExpressionContext context)
    {
        //Console.WriteLine(context.GetText().Contains("()"));
        var leftExpression = Visit(context.expression(0));
        var rightExpression = Visit(context.expression(1));
        var operation = context.binaryOperation().GetText();
        return operation switch
        {
            "*" => _hf.Multiplication(leftExpression, rightExpression),
            "/" => _hf.Division(leftExpression, rightExpression),
            "+" => _hf.Addition(leftExpression, rightExpression),
            "-" => _hf.Subtraction(leftExpression, rightExpression),
            "%" => _hf.Modulo(leftExpression, rightExpression),
            _ => VisitErrorCaller("Operation is not valid")
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitBooleanExpression(CodeParser.BooleanExpressionContext context)
    {
        var leftExpression = Visit(context.expression(0));
        var rightExpression = Visit(context.expression(1));
        var operation = context.booleanOperation().GetText();

        return operation switch
        {
            "<" => _hf.LessThan(leftExpression, rightExpression),
            ">" => _hf.GreaterThan(leftExpression, rightExpression),
            "<=" => _hf.LessEqual(leftExpression, rightExpression),
            ">=" => _hf.GreatEqual(leftExpression, rightExpression),
            "==" => _hf.EqualEqual(leftExpression, rightExpression),
            "<>" => _hf.NotEqual(leftExpression, rightExpression),
            _ => VisitErrorCaller("Operation is not valid")//throw new Exception("Operation is not valid")
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitParenthesizedExpression(CodeParser.ParenthesizedExpressionContext context)
    {
        return Visit(context.expression());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitLogicalExpression(CodeParser.LogicalExpressionContext context)
    {
        var leftExpression = Visit(context.expression(0));
        var rightExpression = Visit(context.expression(1));
        var operation = context.logicalOperation().GetText();
        return operation switch
        {
            "AND" => _hf.AndLogic(leftExpression, rightExpression),
            "OR" => _hf.OrLogic(leftExpression, rightExpression),
            _ => VisitErrorCaller("Operation is not valid")
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitNotBoolExpression(CodeParser.NotBoolExpressionContext context)
    {
        var val = Visit(context.expression());
        return val!.ToString() == "True" ? false: true;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitIfBlock(CodeParser.IfBlockContext context)
    {
        var express = Visit(context.expression());
        if (express is not bool)
        {
            Console.WriteLine($"Expecting a boolean expression {express}");
            Environment.Exit(1);
        }
        switch (express!.ToString())
        {
            case "True":
                Visit(context.block());
                break;
            case "False":
            {
                if (context.elseIfBlock() != null)
                {
                    Visit(context.elseIfBlock());
                }
                break;
            }
            default:
                Console.WriteLine($"Expecting a boolean expression {express}");
                Environment.Exit(1);
                break;
        }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitBlock(CodeParser.BlockContext context)
    {
        return Visit(context.blockLine());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitElseIfBlock(CodeParser.ElseIfBlockContext context)
    {
        if (context.block() != null)
            return Visit(context.block());
        return context.ifBlock() != null ? Visit(context.ifBlock()) : null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitWhileBlock(CodeParser.WhileBlockContext context)
    {
        
        Func<object?, bool> condition = ProcessWhile;
        while (condition(Visit(context.expression())))
        {
            Visit(context.inWhileBlock());
        }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private bool ProcessWhile(object? value)
    {
        if (value is not bool)
        {
            Console.WriteLine($"Expecting a boolean expression {value}");
            Environment.Exit(1);
        }
        switch (value!.ToString())
        {
            case "True":
                return true;
            case "False":
                return false;
            default:
                Console.WriteLine("Value is not a boolean");
                Environment.Exit(1);
                break;
        }

        return false;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public override object? VisitInWhileBlock(CodeParser.InWhileBlockContext context)
    {
        return Visit(context.lines());
    }
}
