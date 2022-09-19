Console.Write("Условие задачи. 5.\n Даны три точки A, B, C на числовой оси.\n Точка C расположена между точками A и B.\n Найти произведение длин отрезков AC и BC.\n");
Console.Write("Выполенение задачи: \n");
Console.Write("Введите точку A: ");
int A;
int B;
int C;
while (!int.TryParse(Console.ReadLine(), out A))
{
    Console.WriteLine("Нужно вводить числа, а не текстовые строки.");
    Console.Write("Введите точку A: ");
}
Console.Write("Введите точку B: ");
while (!int.TryParse(Console.ReadLine(), out B))
{
    Console.WriteLine("Нужно вводить числа, а не текстовые строки.");
    Console.Write("Введите точку B: ");
}
Console.Write("Введите точку C, она должна находиться между А и В: ");
while (!int.TryParse(Console.ReadLine(), out C))
{
    Console.WriteLine("Нужно вводить числа, а не текстовые строки.");
    Console.Write("Введите точку C: ");
}
if (C < B && C > A && A < B)
{
    double sum = (C - A) * (B - C);
    Console.WriteLine($"Произведение отрезков АС и ВС: {sum:0.00}\n");
}
else if (A >= B)
{
    Console.Write("Вы не выполнили условие A < B. Попробуйте еще раз.\n");
}
else if (B <= A)
{
    Console.Write("Вы не выполнили условие B > A. Попробуйте еще раз.\n");
}
else
{
    Console.Write("Вы не выполнили условие A < C < B. Попробуйте еще раз.\n");
}
