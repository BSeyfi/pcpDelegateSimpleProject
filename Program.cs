using System.Threading.Channels;
using DelegateSimplePrograms;

JoinNumbersDelegate joinNumbersDelegate = Join.JoinNumber;

int joinedNumber=joinNumbersDelegate(10,20);
Console.WriteLine(joinedNumber);