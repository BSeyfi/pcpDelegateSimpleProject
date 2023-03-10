namespace DelegateSimplePrograms;

internal delegate int JoinNumbersDelegate(int operand1, int operand2);

public static class Join
{
    public static int JoinNumber(int leftNumber, int rightNumber)
    {
        Console.WriteLine("Joining two integer numbers...");
        return Convert.ToInt32($"{leftNumber}{rightNumber}");
    }

    public static string JoinNumber(string leftNumber, string rightNumber)
    {
        Console.WriteLine("Joining two string numbers...");
        return $"{leftNumber}{rightNumber}";
    }
}