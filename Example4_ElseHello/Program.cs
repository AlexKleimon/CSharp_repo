using System;
Console.Write("Введите имя пользователя: ");
string UserName = Console.ReadLine();

if(UserName.ToLower()=="маша")
{
    Console.WriteLine("ПРИВЕТ МАША!!!)))))");
}
else
{
    Console.WriteLine("Привет {0}!", UserName);
}
