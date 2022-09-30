Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет, Маша. А Женя дома?");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}