Console.Write("What is your name:  ");
string username = Console.ReadLine();

if(username.ToLower() == "tom")
{
    Console.WriteLine("Have a good day, Tom!");
}
else
{
    Console.Write("Hello,  ");
    Console.WriteLine(username);
}