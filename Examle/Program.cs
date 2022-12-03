Console.Write("Введите имя пользова: ");
string username = Console.ReadLine();

if(username.ToLower() == "нина")
{
    Console.WriteLine("Ура, ура это же Нина");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}