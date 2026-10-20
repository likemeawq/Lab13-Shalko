// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}");
// }

// PrintStudentCard("Егор", 18);
// PrintStudentCard("Валерия", 17);

// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);

// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// Console.WriteLine(average);




// Console.WriteLine("Первый блок текста");
// PrintDivider();
// Console.WriteLine("Второй блок текста");
// PrintDivider();
// Console.WriteLine("Третий блок текста");
// void PrintDivider()
// {
//     Console.WriteLine("----------------");
// }

// PrintPerson("Алексей", 17);
// PrintPerson("Мария", 18);
// PrintPerson("Иван", 19);
// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Имя: {name}, Возраст: {age} лет");
// }



int myNumber = 5;
if (IsPositive(myNumber))
{
    Console.WriteLine($"Число {myNumber} — положительное!");
}
else
{
    Console.WriteLine($"Число {myNumber} — отрицательное или ноль.");
}
bool IsPositive(int number)
{
    if (number > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


double myWeight = 70.5;
double myHeight = 1.75;

double bmi = CalculateBmi(myWeight, myHeight);

Console.WriteLine($"При весе {myWeight} кг и росте {myHeight} м индекс массы тела равен: {bmi:F2}");
double CalculateBmi(double weight, double heightMeters)
{
    double result = weight / (heightMeters * heightMeters);
    return result;
}