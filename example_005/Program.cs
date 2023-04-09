Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "дима")
{
    Console.WriteLine("Привет, любимчик");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}