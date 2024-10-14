using System;

class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience; // стаж в роках
    private double salary;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPositionAndExperience(string position, int experience)
    {
        this.position = position;
        this.experience = experience;
        CalculateSalary();
    }
    private void CalculateSalary()
    {
        switch (position.ToLower())
        {
            case "менеджер":
                salary = 20000 + (experience * 1000); // базовий оклад + бонус за стаж
                break;
            case "розробник":
                salary = 25000 + (experience * 1200);
                break;
            case "аналітик":
                salary = 22000 + (experience * 1100);
                break;
            default:
                salary = 15000; 
                break;
        }
    }
    public double CalculateTax()
    {
        double taxRate = 0.15; // 15% податок
        return salary * taxRate;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {salary:F2} грн");
        Console.WriteLine($"Податковий збір: {CalculateTax():F2} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть прізвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть ім'я: ");
        string firstName = Console.ReadLine();

        Employee employee = new Employee(lastName, firstName);

        Console.Write("Введіть посаду: ");
        string position = Console.ReadLine();

        Console.Write("Введіть стаж (в роках): ");
        int experience = int.Parse(Console.ReadLine());

        employee.SetPositionAndExperience(position, experience);
        employee.DisplayInfo();
    }
}

