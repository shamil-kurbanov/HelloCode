int numberA = new Random().Next(1, 10); // Random number between 1 and 
int numberB = new Random().Next(1, 10); // Random number between 1 and 10

int sum = numberA + numberB;        // Sum of two numbers

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("The sum of {0} and {1} is {2}", numberA, numberB, sum);  // Print the sum
    Console.WriteLine("Example Number: ", i); // Print the example number
} // 

// Wait for user to press the Enter key
Console.ReadLine();

// Path: Examples\Example004_Div\Program.cs 

