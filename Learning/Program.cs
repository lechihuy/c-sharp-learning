Console.WriteLine("Enter the first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int temp;

temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("Swap two number:");
Console.WriteLine($"First number:" + firstNumber);
Console.WriteLine($"Second number:" + secondNumber);