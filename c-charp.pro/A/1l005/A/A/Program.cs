﻿class Program
{
    static void Main()
    {
        #region A2
        #region A2.1. Дано двузначное число. Найти:
        ////а) число десятков в нем;
        ////б) число единиц в нем;
        ////в) сумму его цифр;
        ////г) произведение его цифр.

        //Console.WriteLine("Введите двухзначное число: ");
        //int n = int.Parse(Console.ReadLine());

        //if (n < 10 || n > 99)
        //{
        //    Console.WriteLine("Введенное число не трёхзначное");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = n / 10;
        //int sum = ten + edin;
        //int prois = ten * edin;

        //Console.WriteLine($"a:{ten}, b:{edin}, c:{sum}, d:{prois}");

        #endregion

        #region A2.2. Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.

        //Console.WriteLine("Введите двухзначное число");
        //int n = int.Parse(Console.ReadLine());

        //if (n < 10 || n > 99)
        //{
        //    Console.WriteLine("Введенное число не двухзначное");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = n / 10;

        //Console.WriteLine($"Полученное число:{edin}{ten}");

        #endregion

        #region A2.3. Дано трехзначное число. Найти:
        ////а) число единиц в нем;
        ////б) число десятков в нем;
        ////в) сумму его цифр;
        ////г) произведение его цифр.

        //Console.WriteLine("Введиет трёхзначное число: ");
        //int n = int.Parse(Console.ReadLine());

        //if (n < 100 || n > 999)
        //{
        //    Console.WriteLine("Вы введли не трёхзначное число.");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sotn = n / 100;

        //Console.WriteLine($"Вывод: a:{edin}, b:{ten}, c:{edin+ten+sotn}, d:{edin* ten * sotn}");

        #endregion

        #region A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.

        //Console.WriteLine("Введите трёхзначное число");
        //int n = int.Parse(Console.ReadLine());

        //if(n < 100 || n > 999)
        //{
        //    Console.WriteLine("Число не трёхзначное.");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sot = n / 100;

        //Console.WriteLine($"Число справа на лево:{edin}{ten}{sot}");

        #endregion

        #region A2.5 Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.

        //Console.WriteLine("Введите трёхзначное число");
        //int n = int.Parse(Console.ReadLine());

        //if (n < 100 || n > 999)
        //{
        //    Console.WriteLine("Вы ввели не трёхзначное число");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sot = n / 100;

        //Console.WriteLine($"Полученное число: {ten}{edin}{sot}");


        #endregion

        #region A2.6 Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.

        //Console.WriteLine("Введите трёхзначное число ");
        //int n = int.Parse(Console.ReadLine());

        //if( n < 100 || n > 999)
        //{
        //    Console.WriteLine("Введено не трёхзначное число ");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sot = n / 100;

        //Console.WriteLine($"Полученное число: {edin}{sot}{ten}");

        #endregion

        #region A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.

        //Console.WriteLine("Введите трхзначное число ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n < 100 || n > 999)
        //{
        //    Console.WriteLine("Введенно не трёхзначное число");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sot = n / 100;

        //Console.WriteLine($"Полученное число: {ten}{sot}{edin}");

        #endregion

        #region A2.8. Дано трехзначное число. Найти число, полученное при перестановке второй и третьей цифр заданного числа.

        //Console.WriteLine("Введите трёхзначное число");
        //int n = int.Parse(Console.ReadLine());

        //if ( n < 100 || n > 999)
        //{
        //    Console.WriteLine("Вы ввели не трёхзначное число");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sot = n / 100;

        //Console.WriteLine($"Полученное число: {sot}{edin}{ten}");

        #endregion

        #region A2.9. Дано трехзначное число, в котором все цифры различны. Получить шесть чисел, образованных при перестановке цифр заданного числа.

        //Console.WriteLine("Введите трёхзначное число: ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n < 100 || n > 999)
        //{
        //    Console.WriteLine("Введено не трёхзначное число");
        //    return;
        //}

        //int edin = n % 10;
        //int ten  = (n / 10) % 10;
        //int sot = n / 100;

        //Console.WriteLine($"Полученые числа: {sot}{ten}{edin}, {sot}{edin}{ten}, {edin}{sot}{ten}, | {sot}{edin}{ten}, {ten}{edin}{sot}, {ten}{sot}{edin}, | {ten}{edin}{sot}, {edin}{sot}{ten}, {sot}{ten}{edin}");

        #endregion

        #region A2.10. Дано четырехзначное число. Найти:
        ////а) сумму его цифр;
        ////б) произведение его цифр.

        //Console.WriteLine("Введите четырёхзначное число");
        //int n = int.Parse(Console.ReadLine());

        //if ( n < 1000 || n > 9999)
        //{
        //    Console.WriteLine("Введенное число не четырехзначное");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;
        //int sot = (n / 100) % 10;
        //int tis = n / 1000;

        //Console.WriteLine($"Сумма: {edin+ten+sot+tis}| Произведение: {edin*ten*sot*tis}");

        #endregion

        #region A2.11. Дано четырехзначное число. Найти:
        ////а) число, полученное при прочтении его цифр справа налево;
        ////б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа.Например, из числа 5434 получить 4543, из числа 7048 — 784;
        ////в) число, образуемое при перестановке второй и третьей цифр заданного числа.Например, из числа 5084 получить 5804;
        ////г) число, образуемое при перестановке двух первых и двух последних цифр заданного числа.Например, из числа 4566 получить 6645, из числа 7304 — 473.

        //Console.WriteLine("Введите четырёхзанчное число: ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n < 1000 || n > 9999)
        //{
        //    Console.WriteLine("Вы ввеил не четырёхзначное число");
        //}

        //int edin = n % 10 ;
        //int ten = (n % 100)/10;
        //int sot = (n % 1000)/100;
        //int tis = n / 1000;

        //Console.WriteLine($"a: {tis}{sot}{ten}{edin}");
        //Console.WriteLine($"b: {sot}{tis}{edin}{ten}");
        //Console.WriteLine($"c: {tis}{ten}{sot}{edin}");
        //Console.WriteLine($"d: {sot}{edin}{tis}{ten}");


        #endregion

        #region A2.12. Дано натуральное число n (n > 9). Найти:
        ////а) число единиц в нем;
        ////б) число десятков в нем.
        //Console.WriteLine("Введите натуральное число (число больше 9): ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n <= 9)
        //{
        //    Console.WriteLine("Вы ввели неверное число, оно меньше или равно 9");
        //    return;
        //}

        //int edin = n % 10;
        //int ten = (n / 10) % 10;

        //Console.WriteLine($"Единицы: {edin}");
        //Console.WriteLine($"Единицы:  {ten}");

        #endregion

        #region A2.13. Дано натуральное число n (n > 99). Найти:
        ////а) число десятков в нем;
        ////б) число сотен в нем.

        //Console.WriteLine("Введите натуральное число больше 99: ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n <= 99)
        //{
        //    Console.WriteLine("Вы ввели число не подходящее условиям");
        //    return;
        //}

        //int ten = (n / 10) % 10;
        //int sot = (n / 100) % 10;

        //Console.WriteLine($"Десятки: {ten}");
        //Console.WriteLine($"Сотни: {sot}");

        #endregion

        #region A2.14. Дано натуральное число n (n > 999). Найти:
        ////а) число сотен в нем;
        ////б) число тысяч в нем.

        //Console.WriteLine("Введите натуральное число больше 999: ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n <= 999 )
        //{
        //    Console.WriteLine("Вы ввели неверное число по условиям задачи.");
        //    return;
        //}

        //int sot = (n / 100) % 10;
        //int tis = (n / 1000) % 10;

        //Console.WriteLine($"Сотни: {sot}");
        //Console.WriteLine($"Тысячи: {tis}");


        #endregion

        #endregion

        #region A3

        #region A3.1. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось число 237. Найти число x.

        //see this in folder (arts results)
        #endregion

        #region A3.2. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, 
        //а к частному слева приписали последнюю цифру числа x, то получилось число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.

        //Console.WriteLine("Введите трёхзначное число: ");
        //int n = int.Parse(Console.ReadLine());

        //if ( n < 100 || n > 1000)
        //{
        //    Console.WriteLine("Вы ввели не трёхзначное число");
        //    return;
        //}

        //int c = n / 100;
        //int b = (n % 100) % 10;
        //int a = (n % 100) / 10;

        //Console.WriteLine($"Число x: {a}{b}{c}");

        #endregion


















        #endregion
    }

}
