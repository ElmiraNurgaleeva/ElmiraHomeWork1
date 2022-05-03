//Напишем программу, которая будет реагировать на каждого по особеннму исп If  Else :Э

Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}