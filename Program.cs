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

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
Console.WriteLine(average);