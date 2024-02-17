// See https://aka.ms/new-console-template for more information
using WelcomeAppForJenkins;

Console.WriteLine("Please Authenticate yourself");
Signin signin = new Signin();
string user = Console.ReadLine();
string password = Console.ReadLine();
string isValid = signin.Authenticate(user, password);
Console.WriteLine(isValid);
