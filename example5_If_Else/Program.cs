Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "миша")
{
    Console.WriteLine("Ура, Миша ты вернулся!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}