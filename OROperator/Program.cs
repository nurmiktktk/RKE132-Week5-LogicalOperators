﻿//Math >= 90 OR Chemistry >= 90 OR Biology >= 90
// math && chemistry || math && biology ||chemistry && biology

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Wnter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You passed!");
}
else
{
    Console.WriteLine("Your application can not be approved.");
}