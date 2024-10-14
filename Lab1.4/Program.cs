using System;

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public readonly DateTime SurveyDate;

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        SurveyDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата заповнення анкети: {SurveyDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        Console.Write("Введіть ім'я: ");
        string firstName = Console.ReadLine();

        Console.Write("Введіть прізвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть вік: ");
        int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);
        user.DisplayInfo();

        Console.ReadKey();
    }
}
