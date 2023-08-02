//  Code snippet: Example005_ConditionIFElse\Program.cs
Console.WriteLine("Please enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "linda")
{
    Console.WriteLine("Welcome Linda!");
}
else
{
    Console.WriteLine("Welcome " + username);
}

Console.ReadLine(); 