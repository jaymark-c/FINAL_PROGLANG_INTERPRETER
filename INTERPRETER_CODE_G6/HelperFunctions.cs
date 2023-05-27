namespace INTERPRETER_CODE_G6;

public class HelperFunctions
{
    public HelperFunctions(){}

    public object? OrLogic(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue!.ToString()!.ToUpper() == "FALSE" && rightIdentifierValue!.ToString()!.ToUpper() == "FALSE")
            return false;
        return true;
    }

    public object? AndLogic(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue!.ToString()!.ToUpper() == "TRUE" && rightIdentifierValue!.ToString()!.ToUpper() == "FALSE"
            || leftIdentifierValue!.ToString()!.ToUpper() == "FALSE" && rightIdentifierValue!.ToString()!.ToUpper() == "TRUE"
            || leftIdentifierValue!.ToString()!.ToUpper() == "FALSE" && rightIdentifierValue!.ToString()!.ToUpper() == "FALSE")
            return false;
        return true;
    }

    public object? Modulo(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l % r;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf % rf;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }

    public object? Division(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l / r;
        }
        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf / rf;
        }
        Console.WriteLine("Cannot divide");
        Environment.Exit(1);
        return null;
    }

    public object? Multiplication(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l * r;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf * rf;
        }
        
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }
    
    public object? Addition(object? leftIdentifierValue, object? rightIdentifierValue)
    {   
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l + r;
        }
        
        if (leftIdentifierValue is int litf && rightIdentifierValue is float rfti)
        {
            return litf + rfti;
        }
        
        if (leftIdentifierValue is float lfti && rightIdentifierValue is int ritf)
        {
            return lfti + ritf;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf + rf;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }
    public object? Subtraction(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l - r;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf - rf;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }
    
  public object? NotEqual(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue!.ToString()!.ToUpper().Equals(rightIdentifierValue!.ToString()!.ToUpper()))
            return false;
        return true;
    }

  public object? EqualEqual(object? leftIdentifierValue, object? rightIdentifierValue)
  {
      if (leftIdentifierValue!.ToString()!.ToUpper().Equals(rightIdentifierValue!.ToString()!.ToUpper()))
          return true;
      return false;
    }

  public object? GreatEqual(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l >= r ? true : false;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf >= rf ? true : false;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }

  public object? LessEqual(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l <= r ? true : false;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf <= rf ? true : false;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }

  public object? GreaterThan(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l > r ? true : false;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf > rf ? true : false;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }

  public object? LessThan(object? leftIdentifierValue, object? rightIdentifierValue)
    {
        if (leftIdentifierValue is int l && rightIdentifierValue is int r)
        {
            return l < r ? true : false;
        }

        if (leftIdentifierValue is float lf && rightIdentifierValue is float rf)
        {
            return lf < rf ? true : false;
        }
        Console.WriteLine($"Error doing operation for: {leftIdentifierValue} and {rightIdentifierValue}");
        Environment.Exit(1);
        return null;
    }
}