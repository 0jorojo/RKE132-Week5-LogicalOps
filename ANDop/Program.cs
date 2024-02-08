// math >=90; bio >=90; chem >=90

int math, bio, chem;

Console.WriteLine("Please enter your math result:");
math= Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your biology result:");
bio= Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your chemistry result:");   
chem= Int32.Parse(Console.ReadLine());

if (math >= 90 && bio >= 90  && chem >= 90)
{
    Console.WriteLine("Welcome to the club!");
}
else
{
    Console.WriteLine("Nah, better luck next time.");
}