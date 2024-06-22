class Program
{
    static void Main()
    {
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

    }

}
