using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.pro_S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region S1 Простейшие программы. Арифметические выражения


            #region S1.1. Вывести на экран число  с точностью до сотых.
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("S1.1. Вывести на экран число  с точностью до сотых.\n");
            //    Console.WriteLine("Введите число");

            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double z = Math.Round(x, 2);
            //    Console.WriteLine($"ответ: {z}");


            //    Console.ReadLine();
            //}
            #endregion

            #region S1.2. Вывести на экран число e(основание натурального логарифма) с точностью до десятых.
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.");
            //    double e = Math.E;
            //    Console.WriteLine($"Результат: {Math.Round(e,2)} ");
            //    Console.ReadLine();
            //}
            #endregion

            #region S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine($"Вы ввели число: {x}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine($"{x} — вот какое число Вы  ввели");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine($"{1} {13} {49} ");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine($"{7}  {15}  {100}");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double x1 = Convert.ToDouble(Console.ReadLine());
            //    double x2 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine($"{x}  {x1}  {x2}");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double x2 = Convert.ToDouble(Console.ReadLine());
            //    double x3 = Convert.ToDouble(Console.ReadLine());
            //    double x4 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine($"{x} {x2} {x3} {x4}");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.9. Вывести на экран числа 50 и 10 одно под другим.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine($"{50} {10}");
            //    Console.WriteLine($"{10} {50}");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine($"{5} {10} {21}");
            //    Console.WriteLine($"{21} {5} {10} ");
            //    Console.WriteLine($"{21} {10} {5} ");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double x2 = Convert.ToDouble(Console.ReadLine());
            //    double x3 = Convert.ToDouble(Console.ReadLine());
            //    double x4 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Вывод столбиком: ");
            //    Console.WriteLine(x);
            //    Console.WriteLine(x2);
            //    Console.WriteLine(x3);
            //    Console.WriteLine(x4);

            //    Console.ReadLine();
            //}

            #endregion

            #region S1.12. Составить программу вывода на экран следующей информации:5 10 7 см

            //static void Main(string[] args)
            //{
            //    Console.WriteLine($"{5},{10}");
            //    Console.WriteLine($"{7} см");
            //    Console.ReadLine();
            //}

            #endregion

            #region S1.13. Составить программу вывода на экран следующей информации: 2 кг 13 17

            //static void Main(string[] args)
            //{
            //    Console.WriteLine($"{2} кг");
            //    Console.WriteLine($"{13} {17}");
            //    Console.ReadLine();
            //}

            #endregion

            #endregion

            #region S2 Вычисления по известным формулам


            #region S2.1. Составить программу:а) вычисления значения функции y = 7x2+3x+6 при любом значении x;б) вычисления значения функции x = 12a2+7a+12 при любом значении а.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значение x для выражения y=7x(кв)+3x+6");
            //    Console.WriteLine("Введите значение a для выражения x=12a(кв)+7a+12");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    double v = 12 * Math.Pow(a,2) + 7 * a + 12;
            //    double z = 7 * Math.Pow(x, 2) + 3 * x + 6;
            //    Console.WriteLine($"Значение числа при x = {x} будет: {z}");
            //    Console.WriteLine($"Значение числа при a = {a} будет: {v}");

            //    Console.ReadLine();
            //}
            #endregion

            #region S2.2. Дана сторона квадрата. Найти его периметр.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Дайте значение для стороны квадрата: ");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double z = x + x + x + x;

            //    Console.WriteLine($"Периметр квадрата: {z}");
            //    Console.ReadLine();
            //}
            #endregion

            #region S2.3. Дан радиус окружности. Найти ее диаметр.
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значение для радиуса:");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double z = 2 * x;
            //    Console.WriteLine($"Диамеnр окружности: {z}");
            //    Console.ReadLine();
            //}

            #endregion

            #region S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значние h для задачи. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.");
            //    double x = Convert.ToDouble(Console.ReadLine());

            //    double r = Math.Pow(6350,2);
            //    double h = Math.Pow(6350 + x,2);
            //    double rez = Math.Sqrt(h - r);

            //    Console.WriteLine($"Решение задачи: {rez}");
            //    Console.ReadLine();

            //}
            #endregion

            #region S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значение для ребра куба: ");
            //    double x = Convert.ToDouble(Console.ReadLine());

            //    double V = Math.Pow(x, 3);
            //    double Sb = Math.Pow(4 * x, 2);
            //    double Sp = Math.Pow(6 * x, 2);

            //    Console.WriteLine($"Объем куба: {V}");
            //    Console.WriteLine($"Площадь боковая: {Sb}");
            //    Console.WriteLine($"Площадь полная: {Sp}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.


            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите радиус окружности: ");
            //    double r = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Длина окружности: {2*Math.PI*r}");
            //    Console.WriteLine($"Площадь круга: {Math.PI*Math.Pow(r,2)}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите 2 числа: ");
            //    double f = Convert.ToDouble(Console.ReadLine());
            //    double s = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Среднее арифметическое: {(f+s)/2}");
            //    Console.WriteLine($"Среднее арифметическое: {Math.Pow((f*s),1/2)})");//!!!!!

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.8. Известны объем и масса тела. Определить плотность материала этого тела.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите значение для объема: ");
            //    double V = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите значение для массы: ");
            //    double m = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Плотность материала равна: {m/V}");

            //    Console.ReadLine();
            //}
            #endregion

            #region S2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите количество населения: ");
            //    int kol = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Введите площадь территории: ");
            //    double S = Convert.ToDouble(Console.ReadLine());

            //    Console.Write($"Плотность населения равна: {kol / S}");

            //    Console.ReadLine();
            //}
            #endregion

            #region S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите данные для уравнения ax+b=0 (a ≠ 0): ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    if (a != 0)
            //    {
            //        Console.WriteLine($"Решение уравнения: {a * x + b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Значение a ≠ 0");
            //    }

            //    Console.ReadKey();
            //}
            #endregion

            #region S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите значение для 1 катета: ");
            //    double kat1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите значение для 2 катета: ");
            //    double kat2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Гипотенуза равна: {Math.Sqrt(Math.Pow(kat1,2)+Math.Pow(kat2,2))}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите значение для внешнего радиуса: ");
            //    double vnytr = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите значение для внутреннего радиуса: ");
            //    double vvnesh = Convert.ToDouble(Console.ReadLine());

            //    Console.Write($"Площадь кольца равна: {Math.PI * (Math.Pow(vvnesh, 2) - Math.Pow(vnytr, 2))}");

            //    Console.ReadLine();
            //}
            #endregion

            #region S2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значения для a,b,c: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    double c = Convert.ToDouble(Console.ReadLine());

            //    Console.Write($"Периметр равен: {a+b+c}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите 2 числа: ");
            //    double f = Convert.ToDouble(Console.ReadLine());
            //    double s = Convert.ToDouble(Console.ReadLine());

            //    Console.Write($"Среднее арифметическое(модуль): {(Math.Abs(f)+Math.Abs(s))/2}");
            //    Console.Write($"Среднее геометрическое(модуль): {Math.Sqrt(Math.Abs(f)+Math.Abs(s),1/2)}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значение для основания и высоты равнобедренной трапеции: ");
            //    double osn1 = Convert.ToDouble(Console.ReadLine());
            //    double osn2 = Convert.ToDouble(Console.ReadLine());
            //    double h = Convert.ToDouble(Console.ReadLine());

            //    double b1 = (osn1 - osn2) / 2;
            //    double reb = Math.Sqrt(Math.Pow(h,2)+Math.Pow(b1,2));

            //    Console.WriteLine($"Периметр равен: {osn1 + osn2 + reb*2}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите данные для сторон прямоугольника: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Периметр прямоугольника: {a*2 + b*2}");
            //    Console.WriteLine($"Длина диагонали: {Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2))}");

            //    Console.ReadLine();
            //}
            #endregion

            #region S2.15. Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значение для 2 чисел: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Сумма: {a+b}");
            //    Console.WriteLine($"Разность: {a - b}");
            //    Console.WriteLine($"Умножение: {a * b}");
            //    Console.WriteLine($"Частное от деления: {a / b}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.16. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите данные для 3 длин: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    double h = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Объем прямоугольника: {a*b*h}");
            //    Console.WriteLine($"Площадь боковой поверхности: {2*h*(a+b)}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.17. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значение дл 2 точек координат: ");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double y = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2))}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.18. Даны основания и высота равнобедренной трапеции. Найти периметр трапеции.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Датйе значение для оснований и высоты: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    double h = Convert.ToDouble(Console.ReadLine());

            //    double c = Math.Sqrt(Math.Pow(h,2)+Math.Pow((a-b)/2,2));

            //    Console.WriteLine($"Периметр трапеции равен: {a+b+c*2}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.19. Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Введите значения для оснований и угла при большем основании у трапеции: ");
            //    double a = Convert.ToDouble(Console.ReadLine);
            //    double b = Convert.ToDouble(Console.ReadLine);
            //    double yg = Convert.ToDouble(Console.ReadLine);

            //    double c = (a-b)/2 * Math.Sin(yg*Math.PI/180)/Math.Cos(yg*Math.PI/180);

            //    Console.WriteLine($"Площадь трапеции: {a*b*c*c}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.20. Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.

            //static void Main(string() args)
            //{
            //    Console.WriteLine("введите значение для 1 координаты: ");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double y = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("введите значение для 2 координаты: ");
            //    double x2 = Convert.ToDouble(Console.ReadLine());
            //    double y2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("введите значение для 3 координаты: ");
            //    double x3 = Convert.ToDouble(Console.ReadLine());
            //    double y3 = Convert.ToDouble(Console.ReadLine());

            //    double P = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) + Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)) + Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2))

            //    Console.WriteLine($"Периметр треугольника: {P}");

            //    Console.WriteLine($"Площадь треугольника: {Math.Sqrt(P/2*(P/2-x*y)*(P/2-x2*y2)*(P/2-x3*y3)}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.21. Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.

            //static void Main(string[] agrs)
            //{
            //    Console.WriteLine("Введите координаты для 4 вершин четырехугольника: ");

            //    Console.Write("x1 = ");
            //    double x1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y1 = ");
            //    double y1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("x2 = ");
            //    double x2 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y2 = ");
            //    double y2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("x3 = ");
            //    double x3 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y4 = ");
            //    double y3 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("x4 = ");
            //    double x4 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y4 = ");
            //    double y4 = Convert.ToDouble(Console.ReadLine());

            //    double S1 = Math.Sqrt(P / 2 * (P / 2 - x * y) * (P / 2 - x2 * y2) * (P / 2 - x3 * y3);
            //    double S2 = Math.Sqrt(P / 2 * (P / 2 - x * y) * (P / 2 - x4 * y4) * (P / 2 - x3 * y3);

            //    Console.WriteLine($"Площадт четырехугольника равна: {S1 + S2}");

            //    Console.ReadLine();

            //}

            #endregion

            #region S2.22. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

            ////Math.Round(x,2);
            //static void Main(string[] args)
            //{
            //    Console.Write("Введите стоимость 1 кг конфет: ");
            //    double xk = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите стоимость 1 кг печенья: ");
            //    double xp = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите стоимость 1 кг яблок: ");
            //    double xa = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите количество конфет: ");
            //    double kk = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите количество печенья: ");
            //    double kp = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите количество яблок: ");
            //    double ka = Convert.ToDouble(Console.ReadLine());

            //    double kon = Math.Round(xk * kk, 2);
            //    double pech = Math.Round(xp * kp, 2);
            //    double ap = Math.Round(xa * ka, 2);

            //    Console.WriteLine($"Стоимость всей покупки: {kon + pech +ap}");

            //    Console.ReadLine();

            //}

            #endregion

            #region S2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите цену монитора: ");
            //    double m = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите цену системного блока: ");
            //    double sis = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите цену клавиатуры: ");
            //    double kla = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Введите цену мыши: ");
            //    double mis = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Сколько компьютеров вы желаете собрать?");
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"Стоимость компьтеров: {m * n + sis * n + kla * n + mis * n}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите возраст Тани: ");
            //    double t = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите возраст Мити: ");
            //    double m = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Средни   возраст: {(t + m) / 2}");
            //    Console.WriteLine($"Разница у Тани: {t - ((t + m) / 2)}");
            //    Console.WriteLine($"Разница у Тани: {m - ((t + m) / 2)}");

            //    Console.ReadLine();
            //}
            #endregion

            #region S2.25. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час. Определить, через какое время автомобили встретятся, если расстояние между ними было S км

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите скорость 1 автомобиля: ");
            //    double v1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите скорость 2 автомобиля: ");
            //    double v2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите расстояние в км: ");
            //    double s = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Автомобили встретятся через: {s / (v1 + v2)}");

            //    Console.ReadLine();

            //}

            #endregion

            #region S2.26. Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2). Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите скорость 1 машины (1>2): ");
            //    double v1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите скорость 2 машины (1>2): ");
            //    double v2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write($"Расстояние равно: {(v1 - v2) / 0.5 * 30}");

            //    Console.ReadLine();

            //}

            #endregion

            #region S2.27. Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале: а) Фаренгейта; б) Кельвина. Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите значение температуры по Целсию: ");
            //    double tem = Convert.ToDouble(Console.ReadLine());

            //    Console.Write($"Фаренгейт: {tem * 1,8 + 32}");
            //    Console.Write($"Кельвин: {tem + 273.15}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S2.28. У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов  по Фаренгейту». Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См. предыдущую задачу).

            //static void Main(string[] args)
            //{
            //    Console.Write($"450 Фаренгейта это {450 / 1.8 - 32} Цельсия");

            //    Console.ReadLine();
            //}

            #endregion

            #endregion

            #region S3 Часто используемые эффективные алгоритмы

            #region S3.1 Составить программу обмена значениями двух переменных величин.

            //static void Main(string[] args)
            //{
            //    Console.Write("введите переменную a: ");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("введите переменную b: ");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    double ob = a;
            //    a = b;
            //    b = ob;

            //    Console.Write($"a = {a} ,,,, b = {b}");
            //    Console.ReadLine();

            //}

            #endregion

            #region S3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам: а) b присвоить значение c, а присвоить значение b, с присвоить значение а; б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите значение a: ");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите значение b: ");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Введите значение c: ");
            //    double c = Convert.ToDouble(Console.ReadLine());

            //    double a1 = c;
            //    double b2 = a;
            //    double c1 = b;

            //    double b1 = c;
            //    c = a;
            //    a = b;


            //    Console.Write($"Вариант а: a = {a}, b = {b1}, c = {c}");
            //    Console.Write($"Вариант b: a = {a1}, b = {b2}, c = {c1}");

            //    Console.ReadLine();
            //}

            #endregion

            #region S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
            //а) a4 за две операции;
            //б) a6  за три операции;
            //в) a7 за четыре операции;
            //г) a8  за три операции;
            //д) a9 за четыре операции;
            //е) a10  за четыре операции.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите число для значения a: ");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    double a2 = a * a;
            //    double a4 = a2 * a2;
            //    double a6 = a4 * a2;
            //    double a7 = a6 * a;
            //    double a8 = a6 * a2;
            //    double a9 = a7 * a2;
            //    double a10 = a6 * a4;

            //    Console.Write($" a в 4 степени: {a4}");
            //    Console.Write($" a в 6 степени: {a6}");
            //    Console.Write($" a в 7 степени: {a7}");
            //    Console.Write($" a в 8 степени: {a8}");
            //    Console.Write($" a в 9 степени: {a9}");
            //    Console.Write($" a в 10 степени: {a10}");

            //    Console.ReadLine();


            //}

            #endregion

            #region S3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:
            //а) a3 и a10 за четыре операции;
            //б) a4 и a20 за пять операций;
            //в) a5 и a13 за пять операций;
            //г) a5 и a19 за пять операций;
            //д) a2, a5 и a17 за шесть операций;
            //е) a4, a12 и a28 за шесть операций.

            //static void Main(string[] args)
            //{
            //    Console.Write("Введите значнеие числа a: ");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    double a2 = a * a;
            //    double a3 = a * a * a;
            //    double a4 = a * a * a * a;
            //    double a5 = a * a * a * a * a;

            //    double a10 = a3 * a3 * a3 * a;
            //    double a20 = a4 * a4 * a4 * a4 * a4;
            //    double a13 = a5 * a5 * *a3;
            //    double a19 = a5 * a5 * a5 * a4;
            //    double a17 = a5 * a5 * a5 * a2;
            //    double a28 = a5 * a5 * a5 * a5 * a5 * a3;

            //    Console.Write($"а в степени 10: {a10}");
            //    Console.Write($"а в степени 20: {a20}");
            //    Console.Write($"а в степени 13: {a13}");
            //    Console.Write($"а в степени 19: {a19}");
            //    Console.Write($"а в степени 17: {a17}");
            //    Console.Write($"а в степени 28: {a28}");

            //    Console.ReadLine();

            //}

            #endregion

            #region S3.5. Чему будет равно 1010 по Вашему алгоритму? - ну  10000000000

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Чему будет равно 10^10 по Вашему алгоритму?\n");
            //    double rez = Math.Pow(10, 10);
            //    Console.WriteLine(rez);
            //    Console.ReadKey();
            //}
            #endregion

            #endregion
        }
    }
}
