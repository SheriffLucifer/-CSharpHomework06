Console.Clear();
double b1 = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
double k1 = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
double b2 = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
double k2 = GetNumberFromUser($"Введите число ", "Ошибка ввода!");

double findPointX = FindPointX(b1, b2, k1, k2);
double findPointY = FindPointY(k2, findPointX, b2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({findPointX}; {findPointY})");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double FindPointX(double b1, double b2, double k1, double k3)
{
    double x = Math.Round(-(b1 - b2) / (k1 - k2), 2);
    return x;
}

double FindPointY(double k2, double x, double b2)
{
    double y = Math.Round(k1 * x + b1, 2);
    return y;
}
