using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections.Generic;

//### Задание 1: Калькулятор
/*Разработать консольное приложение, которое выполняет базовые
арифметические операции (сложение, вычитание, умножение, деление) между
двумя числами, введенными пользователем*/

//public class Calc
//{
//    public int x;
//    public int z;

//    public float Minus(int x, int z)
//    {
//        return x - z;
//    }

//    public float Plus(int x, int z)
//    {
//        return x + z;
//    }

//    public float Umn(int x, int z)
//    {

//    return x * z; 
//    }

//    public float Del(int x, int z)
//    {
//        return x / z;
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calc calc = new Calc();
//        Console.WriteLine("Введите первое число:");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите второе число:");
//        int b = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите 1 для сложения \n2 - для вычитания\n3 - для деления\n4 - для умножения");
//        int flag = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Результат: ");

//        if (flag == 1) { Console.Write(calc.Plus(a, b)); }
//        else if (flag == 2) { Console.Write(calc.Minus(a, b)); }
//        else if (flag == 3) { Console.Write(calc.Del(a, b)); }
//        else if (flag == 4) { Console.Write(calc.Umn(a, b)); } 
//    }
//}

/*### Задание 2: Обработка строк
Написать программу, которая принимает строку и выводит количество символов,
слов и предложений в строке*/

//public class Counter
//{
//    public string line;

//    public int CounterOfChars(string line)
//    {
//        return line.Length;
//    }

//    public int CounterOfWords(string line)
//    {
//        int counter = 1;

//        for (int i = 0; i < line.Length; i++)
//        {
//            if (line[i] == ' ')
//            {
//                if (line[i + 1] != ' ')
//                {
//                    counter++;
//                }
//            }
//        }
//        return counter;
//    }

//    public int CounterOfLines(string line)
//    {
//        int counter = 1;

//        for (int i = 0; i < line.Length; i++) 
//        {
//            if ((line[i] == '.') && (line[i + 1] != '\n'))
//            {
//                counter++;
//            } 
//        }

//        return counter;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите текст: ");
//        string line = Console.ReadLine();

//        Counter counter = new Counter();

//        Console.Write("\nКоличество символов: ");
//        Console.Write(counter.CounterOfChars(line));

//        Console.Write("\nКоличество слов: ");
//        Console.Write(counter.CounterOfWords(line));

//        Console.Write("\nКоличество предложений: ");
//        Console.Write(counter.CounterOfLines(line));
//    }
//}

//### Задание 3: Таблица умножения
/*Создать программу, которая выводит таблицу умножения на экране для чисел
от 1 до 10*/
//class Program
//{
//    static void Main(string[] args)
//    {
//        for (int i = 1; i < 10; i++)
//        {
//            Console.Write(i + " | ");

//            for (int j = 1; j < 10; j++)
//            {
//                Console.Write("\t" + i * j);
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//        }
//    }
//}

//Задание 4: Факториал числа
/*Написать программу, которая вычисляет факториал числа, введенного
пользователем*/

//public class Factorial
//{
//    int value;

//    public int Factor(int value)
//    {
//        int count = 1;
//        for (int i = value; i > 0; i--)
//        {
//            count = count * i;
//        }

//        return count;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число: ");
//        int value = Convert.ToInt32(Console.ReadLine());

//        Factorial factorial = new Factorial();
//        Console.WriteLine("Факториал: " + factorial.Factor(value));
//    }
//}

/*### Задание 5: Числа Фибоначчи
Разработать программу, которая выводит первые n чисел ряда Фибоначчи, где n
— вводится пользователем*/
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Числа Фибоначи: ");

//        int j = 1;
//        for (int i = 1; i <= n; i += j)
//        {
//            Console.Write("{0} ", i);
//            j = i - j;
//        }
//    }
//}

/*
Задание 6: Поиск простых чисел
Создать программу, которая выводит все простые числа в диапазоне от 1 до n,
где n — вводится пользователем.*/
//class ChkNum
//{
//    public bool IsPrime(int x)
//    {
//        if (x <= 1) return false;
//        for (int i = 2; i <= x / i; i++)
//        {
//            if ((x % i) == 0) return false;
//        }
//        return true;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ChkNum ob = new ChkNum();

//        Console.WriteLine("Введите n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Простые числа: ");

//        for (int i = 2; i < n; i++)
//        {
//            if (ob.IsPrime(i)) Console.WriteLine(i);
//        }
//    }
//}

/*Задание 7: Игра "Угадай число"
Написать игру, в которой пользователь должен угадать случайное число,
сгенерированное программой в диапазоне от 1 до 100.*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random rnd = new Random();

//        int rand = rnd.Next(0, 101);

//        int x = 10;
//        while (x > 0)
//        {
//            Console.WriteLine($"У вас осталось: {x} попыток. Введите число:");
//            int check = Convert.ToInt32( Console.ReadLine() );

//            if (check == rand)
//            {
//                Console.WriteLine("Вы победили. Вот конфетка."); break;
//            }
//            else if (check != rand)
//            {
//                Console.WriteLine("Ошибка.");
//                x--;
//            }

//        }
//    }
//}

/*Задание 8: Калькулятор площади фигур
Разработать приложение, которое вычисляет площадь различных
геометрических фигур (круг, треугольник, прямоугольник) в зависимости от
выбора пользователя*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите фигуру:\n1 - треугольник\n2 - прямоугольник\n3 - круг");
//        int flag = Convert.ToInt16(Console.ReadLine());

//        if (flag == 1)
//        {
//            Console.WriteLine("Введите высоту: ");
//            double h = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Введите сторону, на которую опирается высота: ");
//            double a = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Площадь: " + a * h * 0,5);
//        }

//        if (flag == 2)
//        {
//            Console.WriteLine("Введите высоту:");
//            double a = Convert.ToInt16(Console.ReadLine());

//            Console.WriteLine("Введите ширину: ");
//            double b = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Площадь: " + a * b);
//        }

//        if (flag == 3)
//        {
//            Console.WriteLine("Введите радиус круга: ");
//            double r = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Площадь круга: " + r * 3,14 * 3,14);
//        }

//    }
//}


/*Задание 9: Перевод единиц измерения
Создать программу, которая переводит различные единицы измерения (метры в
километры, килограммы в граммы и т.д.).*/
//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Введите значение: ");
//        double value = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите единицу измерения, из которой нужно конвертировать (kg, g, s, min, m, cm): ");
//        string fromUnit = Console.ReadLine();

//        Console.Write("Введите единицу измерения, в которую нужно конвертировать (kg, g, s, min, m, cm): ");
//        string toUnit = Console.ReadLine();

//        double result = ConvertUnits(value, fromUnit, toUnit);

//        Console.WriteLine($"{value} {fromUnit} равно {result} {toUnit}");
//    }

//    static double ConvertUnits(double value, string fromUnit, string toUnit)
//    {
//        if (fromUnit == "kg" && toUnit == "g")
//            return value * 1000;
//        else if (fromUnit == "g" && toUnit == "kg")
//            return value / 1000;
//        else if (fromUnit == "s" && toUnit == "min")
//            return value / 60;
//        else if (fromUnit == "min" && toUnit == "s")
//            return value * 60;
//        else if (fromUnit == "m" && toUnit == "cm")
//            return value * 100;
//        else if (fromUnit == "cm" && toUnit == "m")
//            return value / 100;

//        return 0;
//    }
//}

/*Задание 10: Калькулятор процентов
Написать программу, которая вычисляет процент от числа, введенного
пользователем*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число: ");
//        int count = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите желаемый процент: ");
//        double perc = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine("Результат: " + count * perc / 100);
//    }
//}

/*Задание 11: Конвертер валют
Разработать приложение, которое переводит суммы из одной валюты в другую,
используя заданный курс*/

//class Program
//{
//    static void Main(string[] args) 
//    {
//        Console.WriteLine("Введите валюту: EUR, USD");
//        string currency = Console.ReadLine().ToLower();

//        if (currency == "eur")
//        {
//            Console.WriteLine("Введите количество: ");
//            double count = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Результат: " + count * 90,0013);
//        }

//        else if (currency == "usd")
//        {
//            Console.WriteLine("Введите количество: ");
//            double count = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Результат: " + count * 99, 2613);
//        }
//    }
//}

/*Задание 12: Работа с массивами
Написать программу, которая находит минимальный, максимальный элемент
массива и их индексы*/

//public class Searcher
//{
//    public int[] SearchMaximum(int[] array)
//    {
//        int max = 0;
//        int index = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//                index = i;
//            }

//        }

//        int[] result = {max, index};
//        return result;
//    }

//    public int[] SearchMinimum(int[] array)
//    {
//        int min = 100;
//        int index = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < min)
//            {
//                min = array[i];
//                index = i;
//            }
//        }

//        int[] result = {min, index};
//        return result;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Searcher searcher = new Searcher();

//        int[] array = new int[10];
//        Console.WriteLine("Сгенерированный массив: ");

//        Random rand = new Random();
//        for (int i = 0; i < 10; i++)
//        {
//            array[i] = rand.Next(1, 100);
//            Console.Write(array[i] + "\t");
//        }

//        Console.WriteLine("\nМаксимум: " + searcher.SearchMaximum(array)[0] + "\nЕго индекс: " + searcher.SearchMinimum(array)[1] + "\nМинимум: " + searcher.SearchMinimum(array)[0] + "\nИндекс: " + searcher.SearchMinimum(array)[1]);

//    }
//}

/*Сортировка массива
Создать программу, которая сортирует массив чисел по возрастанию и
убыванию, используя разные методы сортировки*/

//class SortingArray
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 5, 2, 8, 3, 1, 6, 4 };

//        Console.WriteLine("Оригинальный массив: ");
//        PrintArray(array);

//        BubbleSortAscending(array);
//        Console.WriteLine("Пузырьковая сортировка по возрастанию: ");
//        PrintArray(array);

//        SelectionSortDescending(array);
//        Console.WriteLine("Выборочная сортировка по убыванию:");
//        PrintArray(array);
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//        Console.WriteLine();
//    }

//    static void BubbleSortAscending(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void SelectionSortDescending(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            int maxIndex = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (array[j] > array[maxIndex])
//                {
//                    maxIndex = j;
//                }
//            }
//            int temp = array[maxIndex];
//            array[maxIndex] = array[i];
//            array[i] = temp;
//        }
//    }
//}

/*Задание 14: Поиск в массиве
Разработать программу, которая ищет элемент в массиве и выводит его индекс
или сообщение, что элемент не найден*/

//class Searcher
//{
//    static void SearchInArray(int[] array, int value)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] == value)
//            {
//                Console.WriteLine($"Элемент найден под индексом {i + 1}");
//            }
//            else Console.WriteLine("Элемент не найден.");
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] array = new int[10];
//        Random random = new Random();

//        Console.WriteLine("Массив: ");
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(0, 100);
//            Console.Write(array[i] + "\t");
//        }

//        Console.WriteLine("\nВведите элемент: ");
//        int value = Convert.ToInt16(Console.ReadLine());

//        SearchInArray(array, value);
//    }
//}

/*Задание 15: Обратный порядок массива
Написать программу, которая выводит элементы массива в обратном порядке.*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random rand = new Random();
//        int[] array = new int[10];

//        Console.WriteLine("Массив: ");

//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = rand.Next(0, 100);
//            Console.Write(array[i] + "\t");
//        }

//        Console.WriteLine("\nМассив в обратном порядке: ");
//        for (int i = 9; i != 0; i--)
//        {
//            Console.Write(array[i] + "\t");
//        }
//    }
//}

using System;

using System;
/*Задание 16: Матрица
Создать приложение для работы с матрицами: сложение, вычитание, умножение
матриц, транспонирование матрицы.*/

//public class Matrix
//{
//    private double[,] data;

//    public Matrix(double[,] data)
//    {
//        this.data = data;
//    }

//    public Matrix Add(Matrix other)
//    {
//        double[,] result = new double[data.GetLength(0), data.GetLength(1)];
//        for (int i = 0; i < data.GetLength(0); i++)
//        {
//            for (int j = 0; j < data.GetLength(1); j++)
//            {
//                result[i, j] = data[i, j] + other.data[i, j];
//            }
//        }
//        return new Matrix(result);
//    }

//    public Matrix Sub(Matrix other)
//    {
//        double[,] result = new double[data.GetLength(0), data.GetLength(1)];
//        for (int i = 0; i < data.GetLength(0); i++)
//        {
//            for (int j = 0; j < data.GetLength(1); j++)
//            {
//                result[i, j] = data[i, j] - other.data[i, j];
//            }
//        }
//        return new Matrix(result);
//    }
//    public Matrix Transpose()
//    {
//        double[,] result = new double[data.GetLength(1), data.GetLength(0)];
//        for (int i = 0; i < data.GetLength(0); i++)
//        {
//            for (int j = 0; j < data.GetLength(1); j++)
//            {
//                result[j, i] = data[i, j];
//            }
//        }
//        return new Matrix(result);
//    }

//        public static void Main(string[] args)
//    {
//        double[,] data1 = { { 1, 2 }, { 3, 4 } };
//        double[,] data2 = { { 5, 6 }, { 7, 8 } };

//        Matrix matrix1 = new Matrix(data1);
//        Matrix matrix2 = new Matrix(data2);

//        Matrix resultAdd = matrix1.Add(matrix2);
//        Matrix resultSub = matrix1.Sub(matrix2);
//        Matrix resultTranspose1 = matrix1.Transpose();
//        Matrix resultTranspose2 = matrix2.Transpose();

//        Console.WriteLine("Матрица 1:");
//        PrintMatrix(matrix1);
//        Console.WriteLine("Матрица 2:");
//        PrintMatrix(matrix2);
//        Console.WriteLine("Результат сложения:");
//        PrintMatrix(resultAdd);
//        Console.WriteLine("Результат вычитания:");
//        PrintMatrix(resultSub);
//        Console.WriteLine("Результат транспорирования 1 матрицы: ");
//        PrintMatrix(resultTranspose1);
//        Console.WriteLine("Результат транспорирования 2 матрицы: ");
//        PrintMatrix(resultTranspose2);
//    }

//    public static void PrintMatrix(Matrix matrix)
//    {
//        for (int i = 0; i < matrix.data.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.data.GetLength(1); j++)
//            {
//                Console.Write(matrix.data[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

/*Задание 17: Преобразование чисел
Написать программу, которая переводит число из десятичной системы
счисления в двоичную, восьмеричную и шестнадцатеричную*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число: ");
//        int value = Convert.ToInt32(Console.ReadLine());

//        string binary = Convert.ToString(value, 2);
//        string octal = Convert.ToString(value, 8);
//        string hexadecimal = Convert.ToString(value, 16);

//        Console.WriteLine("Двоичное представление: " + binary + "\nВосьмиричное представление: " + octal + "\nШестнадцатиричное: " + hexadecimal);
//    }
//}

using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Diagnostics.Metrics;
/*Задание 18: Числовая пирамида
Разработать программу, которая выводит числовую пирамиду на экран*/

//class Program
//{
//    static void PrintPyramid(int n)
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(new string(' ', n - i));
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write(j + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void Main(string[] args)
//    {
//        PrintPyramid(10);
//    }
//}

/*Задание 19: Поиск в строках
Написать программу, которая ищет подстроку в строке и выводит ее индекс или
сообщение, что подстрока не найдена*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку: ");
//        string line = Console.ReadLine();

//        Console.WriteLine("Введите подстроку: ");
//        string subline = Console.ReadLine();

//        if (line.Contains(subline)) Console.WriteLine("Подстрока найдена под индексом: " + line.IndexOf(subline));
//        else Console.WriteLine("Подстрока не найдена.");
//    }
//}

/*Задание 20: Удаление пробелов
Создать программу, которая удаляет все лишние пробелы из строки, оставляя
по одному между словами*/

//class LineCleaner
//{
//    public string LineClean(string line)
//    {
//        return string.Join(" ", line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку: ");
//        string line = Console.ReadLine();

//        LineCleaner cleaner = new LineCleaner();
//        Console.WriteLine("Чистая строка: " + cleaner.LineClean(line));
//    }
//}


/*Задание 21: Калькулятор даты
Написать программу, которая вычисляет количество дней между двумя датами,
введенными пользователем.*/

//class DayCounter
//{
//    public string CountTheDays(DateTime date2)
//    {
//        DateTime dayt1 = DateTime.Now;

//        return (dayt1 - date2).TotalDays.ToString();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите дату (год, месяц, день): ");
//        string dataString = Console.ReadLine();

//        string[] dataArray = dataString.Split(',');
//        if (dataArray.Length != 3)
//        {
//            Console.WriteLine("Invalid input format. Please enter year, month, day separated by commas.");
//            return;
//        }

//        int year, month, day;
//        if (!int.TryParse(dataArray[0].Trim(), out year) ||
//            !int.TryParse(dataArray[1].Trim(), out month) ||
//            !int.TryParse(dataArray[2].Trim(), out day))
//        {
//            Console.WriteLine("Invalid input. Please enter valid year, month, and day.");
//            return;
//        }
//        var date2 = new DateTime(year, month, day, 7, 0, 0);

//        DayCounter dayCounter = new DayCounter();

//        Console.WriteLine($"Количество дней с введенной даты по сегодня: {dayCounter.CountTheDays(date2)}");
//    }
//}


/*### Задание 22: Валидация данных
Разработать программу, которая проверяет корректность ввода данных
(например, номер телефона, e-mail и т.д.)*/

//class PhoneValidator
//{
//    public bool ValidateThePhone(string phoneNumber)
//    {
//        if (phoneNumber == null && phoneNumber.Length <= 0)
//        {
//            return false;
//        }

//        else
//        {
//            Regex pattern = new Regex("^\\+?[1-9][0-9]{7,14}$");

//            if (pattern.IsMatch(phoneNumber))
//            {
//                return true;
//            }
//        }

//        return false;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        PhoneValidator phoneValidator = new PhoneValidator();

//        Console.WriteLine("Введите номер телефона: ");
//        string phoneNumber = Console.ReadLine();

//        if (phoneValidator.ValidateThePhone(phoneNumber) == true)
//        {
//            Console.WriteLine("Введенная строка является номером.");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка ввода.");
//        }
//    }
//}

/*Задание 23: Генерация паролей
Создать приложение, которое генерирует случайный пароль заданной длины, с
учетом использования букв, цифр и специальных символов*/

/*class PasswordGenerator
{
    public string GeneratePassword(int length)
    {
        string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*_-=+";

        StringBuilder result = new StringBuilder();

        Random random = new Random();

        while(0 < length--)
        {
            result.Append(symbols[random.Next(symbols.Length)]);
        }

        return result.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длина пароля: ");

        int length = int.Parse(Console.ReadLine());

        PasswordGenerator passwordGenerator = new PasswordGenerator();

        Console.WriteLine($"Сгенерированный пароль: {passwordGenerator.GeneratePassword(length)}");
    }
}*/

/*Задание 24: Чек на покупки
Написать программу, которая принимает список покупок и их стоимость, а затем
выводит чек с общей суммой и НДС.*/

//class TaxCounter
//{
//    public double[] CalculateTax(Dictionary<string, double> purchases)
//    {
//        double resultSum = 0;
//        double tax = 0;

//        foreach(var purchase in purchases)
//        {
//            resultSum += purchase.Value;

//            tax += purchase.Value * 0.13;
//        }

//        double[] result = { tax, resultSum };

//        return result;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        TaxCounter taxCounter = new TaxCounter();

//        Console.WriteLine("Вводите покупки и их стоимость по одной через пробел (имя цена(щетка 3000)). Для выхода введите exit.");

//        Dictionary<string, double> purchases = new Dictionary<string, double>();

//        while (true)
//        {
//            string str = Console.ReadLine().ToLower();

//            if (str == "exit")
//            {
//                break;
//            }

//            string[] data = str.Split();

//            string name = data[0];
//            double price = Convert.ToDouble(data[1]);

//            purchases.Add(name, price);
//        }

//        Console.WriteLine("\nЧек\n--------------------------------------------------------\n");
//        foreach(var purchase in purchases)
//        {
//            Console.WriteLine(purchase.Key + purchase.Value);
//        }
//        Console.WriteLine("\n-----------------------------------------------------\n");
//        Console.WriteLine($"Итого: {taxCounter.CalculateTax(purchases)[1]}.\nИз них налога: {taxCounter.CalculateTax(purchases)[0]}");
//    }
//}

/*Задание 24: Чек на покупки
Написать программу, которая принимает список покупок и их стоимость, а затем
выводит чек с общей суммой и НДС*/

/*class WordCounter
{
    public Dictionary<string, int> CountWords(string text)
    {
        string cleanText = Regex.Replace(text, "[!\"#$%&'()*+,-./:;<=>?@\\[\\]^_`{|}~]", string.Empty);

        string[] words = cleanText.ToLower().Split(' ');

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts.Add(word, 1);
            }

        }
        return wordCounts;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();

        WordCounter wordCounter = new WordCounter();

        Dictionary<string, int> result = wordCounter.CountWords(text);

        Console.WriteLine($"Слова и количество их вхождений: ");

        foreach (var word in result)
        {
            Console.WriteLine($"{word.Key}: {word.Value}");
        }
    }
}*/

