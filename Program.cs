PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("   Конец программы");
    Console.WriteLine("X_X");
}

void PrintStudentCard(string name, int age)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}");
}

PrintStudentCard("Егор", 18);
PrintStudentCard("Валерия", 17);

double CalculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}

double result = CalculateScholarship(2000, 15);
Console.WriteLine(result);