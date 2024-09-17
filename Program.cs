using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Excel = Microsoft.Office.Interop.Excel;


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
/*{
    static void Main(string[] args)
    {
        Calc calc = new Calc();
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите 1 для сложения \n2 - для вычитания\n3 - для деления\n4 - для умножения");
        int flag = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат: ");
*/
//        if (flag == 1) { Console.Write(calc.Plus(a, b)); }
//        else if (flag == 2) { Console.Write(calc.Minus(a, b)); }
//        else if (flag == 3) { Console.Write(calc.Del(a, b)); }
//        else if (flag == 4) { Console.Write(calc.Umn(a, b)); } 

/*else*/
/*{
    Console.WriteLine("Ошибка ввода.");
}*/
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


/*Задание 25: Анализ текста
Разработать приложение, которое анализирует текст, введенный
пользователем, и выводит статистику по частоте использования каждого слова*/


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

/*Задание 26: Калькулятор времени
Создать программу, которая складывает или вычитает часы и минуты,
введенные пользователем*/

/*public class TimeCalculator
{
    private int hours { get; set; }
    private int minutes { get; set; }
    private int seconds { get; set; }

    public int resultTime;

    public TimeCalculator()
    {
        hours = 0; minutes = 0; seconds = 0; resultTime = 0;

        GetHours();
        GetMinutes();
        GetSeconds();

        BringingTime();
    }

    public void GetHours()
    {
        Console.WriteLine("Введите количество часов: ");

        hours = int.Parse(Console.ReadLine());
    }

    public void GetMinutes()
    {
        Console.WriteLine("Введите количество минут: ");

        minutes = int.Parse(Console.ReadLine());
    }

    public void GetSeconds()
    {
        Console.WriteLine("Введите количество секунд: ");

        seconds = int.Parse(Console.ReadLine());
    }

    private void BringingTime()
    {
        resultTime = seconds + minutes * 60 + hours * 3600;
    }

    private int ChoosingAction()
    {
        Console.WriteLine("Введите действие:\n1 - сложение времени\n2 - вычитание времени");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1) return 1;

        else if (choice == 2) return 2;

        else return 0;
    }

    public int TimeCalculate(int time1, int time2)
    {
        int choice = ChoosingAction();

        int result = 0;

        try
        {
            if (choice == 1) result = time1 + time2;

            else if (choice == 2) result = time1 - time2;
        }

        catch (Exception e)
        {
            Console.WriteLine($"Ошибка вычисления: {e.Message}");
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое время. ");

        TimeCalculator timeCalculator = new TimeCalculator();
        Console.Clear();

        Console.WriteLine("Введите второе время.");

        TimeCalculator timeCalculator1 = new TimeCalculator();
        Console.Clear();

        int resultTime = timeCalculator.TimeCalculate(timeCalculator.resultTime, timeCalculator1.resultTime);

        int hours = resultTime / 3600;
        int minutes = (resultTime % 3600) / 60;
        int seconds = resultTime % 60;

        Console.WriteLine($"Итого: {hours} часов, {minutes} минут, {seconds} секунд");
    }
}*/

/*Задание 27: Нахождение корней уравнения
Написать программу, которая находит корни квадратного уравнения*/

/*public class EquationCalculator
{
    private double a {  get; set; }
    private double b {  get; set; }
    private double c {  get; set; }

    private double d;

    public EquationCalculator()
    {
        a = 0;
        b = 0;
        c = 0;

        GetCoefficients();
        CalculateDiscriminant();
    }

    private void GetCoefficients()
    {
        Console.WriteLine("Введите коэффициент a:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент с: ");
        c = double.Parse(Console.ReadLine());
    }

    private void CalculateDiscriminant()
    {
        d = b * b - 4 * a * c;
    }

    public double[] CalculateRoots()
    {
        double[] roots;

        if (d ==  0)
        {
            roots = new double[1];

            double x = -b / (2 * a);

            roots[0] = x;
        }

        else if (d > 0)
        {
            roots = new double[2];

            double x1 = (-b + Math.Sqrt(d)) / (2 * a);

            double x2 = (-b - Math.Sqrt(d)) / (2 * a);

            roots[0] = x1;
            roots[1] = x2;
        }

        else
        {
            throw new InvalidOperationException("Уравнение не имеет действительных корней.");
        }

        return roots;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EquationCalculator equationCalculator = new EquationCalculator();

        double[] result = equationCalculator.CalculateRoots();

        if (result.Length == 2) Console.WriteLine($"Уравнение имеет два корня.\nx1 = {result[0]}\nx2 = {result[1]}");

        else if (result.Length == 1) Console.WriteLine($"Уравнение имеет один корень.\nx = {result[0]}");
    }
}*/

/*Задание 28: Система уравнений
Разработать программу, которая решает систему линейных уравнений с двумя
переменными*/

/*public class LinearEquationSystem
{
    private double a {  get; set; }
    private double b { get; set; }
    private double c { get; set; }
    private double d { get; set; }
    private double e { get; set; }
    private double f { get; set; }

    public LinearEquationSystem()
    {
        a = 0; b = 0; c = 0; d = 0; e = 0; f = 0;

        GetCoefficients();
    }

    public (double, double) SolveSystem()
    {
        double det = a * d - b * c;

        if (det == 0)

        { 
            throw new InvalidOperationException("Система уравнений не имеет решения.");
        }

        double x = (e * d - b * f) / det;

        double y = (a * f - e * c) / det;

        return (x, y);
    }

    private void GetCoefficients()
    {
        Console.WriteLine("Введите коэффициент а: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент c: ");
        c = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент а1: ");
        d = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент b1: ");
        e = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент c1: ");
        f = double.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinearEquationSystem linearEquationSystem = new LinearEquationSystem();

        (double x, double y) = linearEquationSystem.SolveSystem();

        if (x != 0 && y != 0) Console.WriteLine($"Решение системы:\nx = {x}\ny = {y}");
    }
}*/
/*
Задание 29: Дисковый мониторинг
Создать приложение, которое выводит информацию о доступных на компьютере
дисках (размер, свободное место и т.д.)*/

/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Информация по дискам: \n");

        DriveInfo[] driveInfos = DriveInfo.GetDrives();

        foreach (DriveInfo d in driveInfos)
        {
            Console.WriteLine($"Информация по диску: {d.Name}");
            Console.WriteLine("Тип диска: {0}", d.DriveType);

            if (d.IsReady == true)
            {
                Console.WriteLine("  Том: {0,15}", d.VolumeLabel);
                Console.WriteLine("  Файловая система: {0,15}", d.DriveFormat);
                Console.WriteLine("  Доступное пространство для текущего пользователя: {0,15} bytes", d.AvailableFreeSpace);
                Console.WriteLine("  Общее количество свободного пространства:          {0,15} bytes", d.TotalFreeSpace);
                Console.WriteLine("  Общий размер диска:            {0,15} bytes", d.TotalSize);

                Console.WriteLine();
            }
        }
    }
}*/

/*Задание 30: Файловый менеджер
Написать консольное приложение, которое позволяет выполнять операции с
файлами (создание, удаление, копирование, перемещение).*/

/*public class FileOperator
{
    private string _path;
    public FileOperator()
    {
        _path = AppDomain.CurrentDomain.BaseDirectory;
        Choice();
    }

    private void Choice()
    {
        bool exitProgram = false;

        while(!exitProgram)
        {
            Console.WriteLine("Введите действие:\n1 - Создать файл\n2 - Переместить файл\n3 - удалить файл\n4 - Скопировать файл\n5 - выход");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите название файла с расширением (\"log.txt\")");

                        string fileName = Console.ReadLine();
                        Console.Clear();

                        if (string.IsNullOrEmpty(fileName))
                        {
                            Console.WriteLine("Имя файла не может быть пустым.");
                            break;
                        }

                        string filePath = Path.Combine(_path, fileName);

                        if (File.Exists(filePath))
                        {
                            Console.WriteLine("Файл с таким названием уже существует.");
                            break;
                        }

                        try
                        {
                            File.Create(filePath);
                            Console.WriteLine("Файл создан.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Ошибка создания файла: {e.Message}");
                        }
                        break;

                    case 2:
                        if (string.IsNullOrEmpty(_path))
                        {
                            Console.WriteLine("Каталог не установлен.");
                            break;
                        }

                        Console.WriteLine("Введите имя файла для перемещения: ");

                        string sourceFileName = Console.ReadLine();
                        Console.Clear();

                        if (string.IsNullOrEmpty(sourceFileName))
                        {
                            Console.WriteLine("Имя файла не может быть пустым.");
                            break;
                        }

                        filePath = Path.Combine(_path, sourceFileName);

                        if (!File.Exists(filePath))
                        {
                            Console.WriteLine("Файл с таким именем не найден.");
                            break;
                        }
                        Console.WriteLine("Введите новый путь для файла: ");

                        string destFileName = Console.ReadLine();
                        Console.Clear();

                        if (string.IsNullOrEmpty(destFileName))
                        {
                            Console.WriteLine("Путь не может быть пустым.");
                            break;
                        }

                        else if (!File.Exists(destFileName))
                        {
                            Console.WriteLine("Каталог не найден.");
                            break;
                        }

                        try
                        {
                            File.Move(sourceFileName, destFileName);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ошибка перемещения: " + ex.Message);
                        }
                        break;

                    case 3:
                        if (string.IsNullOrEmpty(_path))
                        {
                            Console.WriteLine("Каталог не установлен.");
                            break;
                        }

                        Console.WriteLine("Введите имя файла для удаления: ");

                        fileName = Console.ReadLine();
                        Console.Clear();

                        if (string.IsNullOrEmpty(fileName))
                        {
                            Console.WriteLine("Имя файла не может быть пустым.");
                            break;
                        }

                        filePath = Path.Combine(_path, fileName);

                        if (!File.Exists(filePath))
                        {
                            Console.WriteLine("Файл не найден.");
                            break;
                        }

                        try
                        {
                            File.Delete(filePath);
                            Console.WriteLine("Файл успешно удален.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ошибка удаления: " + ex.Message);
                        }
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(_path))
                        {
                            Console.WriteLine("Каталог не установлен.");
                            break;
                        }

                        Console.WriteLine("Введите имя файла для копирования: ");

                        fileName = Console.ReadLine();
                        Console.Clear();

                        if (string.IsNullOrEmpty(fileName))
                        {
                            Console.WriteLine("Имя файла не может быть пустым.");
                            break;
                        }

                        filePath = Path.Combine(_path, fileName);

                        if (!File.Exists(filePath))
                        {
                            Console.WriteLine("Файл не найден.");
                            break;
                        }

                        Console.WriteLine("Введите путь для копирования файла: ");
                        string destinationPath = Console.ReadLine();
                        Console.Clear();

                        if (string.IsNullOrEmpty(destinationPath))
                        {
                            Console.WriteLine("Путь для копирования не может быть пустым.");
                            break;
                        }

                        try
                        {
                            File.Copy(filePath, Path.Combine(destinationPath, fileName));
                            Console.WriteLine("Файл успешно скопирован.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ошибка копирования: " + ex.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Выход из программы.");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        FileOperator fileOperator = new FileOperator();
    }
}*/

/*Задание 31: Работа с JSON
Создать программу, которая читает данные из JSON-файла, обрабатывает их и
выводит на экран в формате таблицы*/

/*public class JSONHandler
{
    public void JSONWrite()
    {
        Console.WriteLine("Введите количество записей: ");

        int count = int.Parse(Console.ReadLine());

        string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*_-=+";
        Random rand = new Random();

        Dictionary<int, JSONData> jsonDataList = new Dictionary<int, JSONData>();

        for (int i = 0; i < count; i++)
        {
            string data = new string(Enumerable.Repeat(symbols, 10).Select(s => s[rand.Next(symbols.Length)]).ToArray());
            JSONData jsonData = new JSONData { Data = data, Index = i };
            jsonDataList.Add(i, jsonData);
        }

        using (FileStream fs = new FileStream("data.json", FileMode.OpenOrCreate))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(JsonConvert.SerializeObject(jsonDataList));
            }
        }
    }

    public void JSONRead()
    {
        Console.WriteLine("JSON DATA ");

        using (StreamReader sr = new StreamReader("data.json"))
        {
            string json = sr.ReadToEnd();
            Dictionary<int, JSONData> jsonDataList = JsonConvert.DeserializeObject<Dictionary<int, JSONData>>(json);

            Console.WriteLine("Index\tData");
            foreach (var kvp in jsonDataList)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value.Data}");
            }
        }
    }
}

public class JSONData
{
    public string Data { get; set; }
    public int Index { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        JSONHandler handler = new JSONHandler();

        handler.JSONWrite();
        handler.JSONRead();
    }
}*/

/*Задание 32: Работа с XML
Написать программу, которая читает данные из XML-файла, обрабатывает их и
выводит на экран в формате таблицы*/

// ОНО НЕ РАБОТАЕТ ЕСЛИ ЧТО Я УЖЕ УСТАЛ ПЕРЕПИСЫВАТЬ ВСЁ ПУСТЬ БУДЕТ ТАК Я НЕ ЗНАЮ ЧЕ С НИМ НЕ ТАК

/*[XmlRoot("Users", Namespace = "http://example.com/users")]
public class Users
{
    [XmlElement("User")]
    public List<User> userList { get; set; } = new List<User>();

    public void Add(User user)
    {
        userList.Add(user);
    }
}

[XmlType(Namespace = "http://example.com/users")]
public class User
{
    [XmlElement("Name")]
    public string name { get; set; }
    [XmlElement("Email")]
    public string email { get; set; }
    [XmlElement("Password")]
    public string password { get; set; }

    public User(string name, string email, string password)
    {
        this.name = name;
        this.email = email;
        this.password = password;
    }
}

public class XMLRedactor
{
    private Users users;

    public XMLRedactor(Users users)
    {
        this.users = users;
    }

    public void WriteData()
    {
        try
        {
            using (XmlWriter writer = XmlWriter.Create("data.xml"))
            {
                XmlRootAttribute root = new XmlRootAttribute("Users");
                root.Namespace = "http://example.com/users";
                XmlSerializer serializer = new XmlSerializer(typeof(Users), root);
                serializer.Serialize(writer, users);
            }
            Console.WriteLine("Данные успешно записаны в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка ввода в файл: " + ex.Message);
            Console.WriteLine("Подробная информация об ошибке:");
            Console.WriteLine(ex.StackTrace);
        }
    }

    public void ReadData()
    {
        try
        {
            using (XmlReader reader = XmlReader.Create("data.xml"))
            {
                XmlRootAttribute root = new XmlRootAttribute("Users");
                root.Namespace = "http://example.com/users";
                XmlSerializer deserializer = new XmlSerializer(typeof(Users), root);
                Users deserializedUsers = (Users)deserializer.Deserialize(reader);

                Console.WriteLine("Имя\tПочта\tПароль");
                foreach (User user in deserializedUsers.userList)
                {
                    Console.WriteLine($"{user.name}\t{user.email}\t{user.password}");
                }
            }
            Console.WriteLine("Данные успешно прочитаны из файла.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка чтения из файла: " + ex.Message);
            Console.WriteLine("Подробная информация об ошибке:");
            Console.WriteLine(ex.StackTrace);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество записей в файл: ");

        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Некорректное количество записей.");
            return;
        }

        Users users = new Users();

        for (int i = 0;  i < count; i++) 
        {
            Console.WriteLine("Введите имя пользователя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите почту пользователя: ");
            string mail = Console.ReadLine();

            Console.WriteLine("Введите пароль пользователя: ");
            string password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Некорректные данные пользователя.");
                continue;
            }

            User user = new User(name, mail, password);
            users.Add(user);
        }

        if (users.userList.Count == 0)
        {
            Console.WriteLine("Нет данных для записи в файл.");
            return;
        }

        XMLRedactor redactor = new XMLRedactor(users);
        redactor.WriteData();
        redactor.ReadData();
    }
}*/

/*Задание 33: Ведение списка дел
Разработать приложение для ведения списка дел. Пользователь может
добавлять, удалять и отмечать задачи как выполненные*/

/*public class TodoItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public TodoItem(string description, bool IsCompleted)
    {
        Description = description;
        IsCompleted = false;
    }
}*/

/*class Program
{
    static void Main(string[] args)
    {
        List<TodoItem> todoList = new List<TodoItem>();

        bool isExit = false;

        while (!isExit)
        {

            Console.WriteLine("1. Добавить задачу\n2. Удалить задачу\n3. Вывести список задач\n4. Отметить как выполненное\n5. Выход");

            int option = int.Parse(Console.ReadLine());

            if (option <= 0 || option > 5)
            {
                Console.WriteLine("Ошибка ввода.");
                isExit = true;
            }

            switch(option)
            {
                case 1:
                    AddTask(todoList);
                    break;

                case 2:
                    DeleteTask(todoList);
                    break;

                case 3:
                    PrintTodoList(todoList);
                    break;

                case 4:
                    MarkAsCompleted(todoList);
                    break;

                case 5:
                    Console.WriteLine("Выход...");
                    isExit = true;
                    break;
            }
        }
    }

    static void AddTask(List<TodoItem> todoList)
    {
        Console.WriteLine("Введите описание задачи: ");
        string desc = Console.ReadLine();

        if (string.IsNullOrEmpty(desc))
        {
            Console.WriteLine("Описание не может быть пустым.");
            return;
        }

        TodoItem task = new TodoItem(desc, false);
        todoList.Add(task);
    }

    static void DeleteTask(List<TodoItem> todoList)
    {
        Console.WriteLine("Введите порядковый номер задачи для удаления: ");
        int num = int.Parse(Console.ReadLine()) - 1;

        if (num >= 0 && num < todoList.Count) 
        {
            todoList.RemoveAt(num);
            Console.WriteLine("Задача успешно удалена.");
        }

        else
        {
            Console.WriteLine("Неверный ввод. Повторите снова.");
            return;
        }
    }

    static void PrintTodoList(List<TodoItem> todoList)
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}.\t{todoList[i].Description} : {(todoList[i].IsCompleted ? "ВЫПОЛНЕНА" : "ЖДЕТ ВЫПОЛНЕНИЯ")}");
        }
    }

    static void MarkAsCompleted(List<TodoItem> todoList)
    {
        Console.WriteLine("Введите порядковый номер задачи для отметки: ");
        int num = int.Parse(Console.ReadLine()) - 1;

        if (num >= 0 && num < todoList.Count)
        {
            todoList[num].IsCompleted = true;
            Console.WriteLine("Задача отмечена выполненной.");
        }

        else
        {
            Console.WriteLine("Невалидный ввод.");
            return;
        }
    }
}*/

/*Задание 34: Работа с файлами
Создать программу, которая читает текст из файла и записывает его в другой
файл с изменением регистра букв (все строчные заменить на прописные и
наоборот)*/

/*public class RegisterRedactor
{
    public string replacementString { get; set; }

    public RegisterRedactor()
    {
        GetString();
    }

    private void GetString()
    {
        Console.WriteLine("Введите строку для замены регистров: ");

        replacementString = Console.ReadLine();

        ReplaceChars();
    }

    private void ReplaceChars()
    {
        char[] chars = replacementString.ToCharArray();
        List<string> newChars = new List<string>();

        foreach (var c in chars)
        {
            string tmp;
            if (char.IsUpper(c))
            {
                tmp = char.ToLower(c).ToString();
                newChars.Add(tmp);
            }

            else
            {
                tmp = char.ToUpper(c).ToString();
                newChars.Add(tmp);
            }
        }

        Console.WriteLine("Результат: ");
        foreach (var c in newChars)
        {
            Console.Write(c);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        RegisterRedactor redact = new RegisterRedactor();
    }
}*/

/*Задание 35: Календарь
Написать программу, которая выводит календарь на текущий месяц и позволяет
пользователю вводить заметки на каждый день.*/

/*public class Calendar
{
    private System.DateTime now = DateTime.Now;

    private int daysInMonth { get; set; }

    public static Dictionary<int, Task> tasks = new Dictionary<int, Task>();

    public Calendar()
    {
        daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
    }

    public void AddTask()
    {
        Console.WriteLine("Введите день месяца: ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите описание задачи: ");
        string task = Console.ReadLine();

        tasks.Add(day, new Task(task, day));
    }

    public void GetCalendar()
    {
        Console.WriteLine("  Пн\tВт\tСр\tЧт\tПт\tСб\tВс");

        DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
        int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;
        int day = 1;

        if (dayOfWeek == 0)
        {
            dayOfWeek = 7;
        }

        int weeks = (int)Math.Ceiling((double)(daysInMonth + dayOfWeek - 1) / 7);

        for (int i = 0; i < weeks; i++)
        {
            for (int j = 1; j < 8; j++)
            {
                if (i == 0 && j < dayOfWeek)
                {
                    Console.Write("\t");
                }
                else if (day <= daysInMonth)
                {
                    Console.Write(day + "\t");

                    day++;
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }

    public void GetTasksList()
    {
        Console.WriteLine("Список задач: ");
        foreach (var task in tasks)
        {
            string status = task.Value.IsCompleted ? "Выполнено" : "Не выполнено";
            Console.WriteLine($"{task.Key}. {task.Value.Description} - {status}");
        }
    }
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int Day { get; set; }

        public Task(string description, int day)
        {
            description = Description;
            IsCompleted = false;
            day = Day;
        }

        public static void MarkAsCompleted(Task task)
        {
            Console.WriteLine("Введите день, на который определена задача: ");
            int day = int.Parse(Console.ReadLine());

            try
            {
                task.IsCompleted = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка выполнения задачи: " + ex.Message);
            }



        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        Calendar calendar = new Calendar();

        bool isExit = false;
        while (!isExit)
        {
            try
            {
                Console.WriteLine("Введите действие:\n1 - Вывести календарь\n2 - создать задачу\n3 - вывести список задач\n4 - пометить задачу выполненной\n5 - выход");
                int choice = int.Parse(Console.ReadLine());

                if (choice <= 0 || choice > 5)
                {
                    Console.WriteLine("Ошибка ввода.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        calendar.GetCalendar();
                        Console.WriteLine();
                        break;

                    case 2:
                        calendar.AddTask();
                        break;

                    case 3:
                        calendar.GetTasksList();
                        break;

                    case 4:
                        Console.WriteLine("Введите день, на который хотели бы установить задачу: ");
                        int day = int.Parse(Console.ReadLine());

                        foreach (var task in Calendar.tasks)
                        {
                            if (task.Key == day)
                            {
                                var completedTask = task.Value;
                                completedTask.IsCompleted = true;
                            }
                        }
                        break;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}*/

/*Задание 36: Учёт успеваемости студентов
Разработать систему учета успеваемости студентов, которая хранит
информацию о студентах и их оценках по предметам*/

/*public class Student
{
    public string Name { get; set; }
    public string SecondName { get; set; }
    public Dictionary<string, List<int>> Evaluations { get; set; }

    public Student(string name, string secondName)
    {
        Evaluations = new Dictionary<string, List<int>>();
        Name = name;
        SecondName = secondName;
    }

    public void AddRatings()
    {
        while (true)
        {
            Console.WriteLine("Введите название предмета:\nexit - для выхода");
            string discipline = Console.ReadLine();

            if (string.IsNullOrEmpty(discipline))
            {
                Console.WriteLine("Название дисциплины не может быть пустым. Введите снова: ");
                continue;
            }

            else if (discipline == "exit")
            {
                break;
            }

            List<int> ratings = new List<int>();

            while (true)
            {
                Console.WriteLine("Введите оценку. 0 для выхода.");
                int rating = int.Parse(Console.ReadLine());

                if (rating < 0 || rating > 5)
                {
                    Console.WriteLine("Неверная оценка. Оценка не может быть меньше нуля и больше 5. Введите снова.");
                    continue;
                }

                else if (rating == 0)
                {
                    break;
                }

                ratings.Add(rating);
            }

            if (ratings.Count > 0)
            {
                Evaluations.Add(discipline, ratings);
            }
        }
    }

    public double GetAverage()
    {
        double average = 0;

        int sum = 0;
        int count = 0;

        foreach (var discipline in Evaluations)
        {
            foreach (int rating in discipline.Value)
            {
                sum += rating;
                count++;
            }
        }

        if (count > 0)
        {
            average = (double)sum / count;
        }

        return average;
    }
}

public class Class
{
    public List<Student> Students { get; set; }

    public Class()
    {
        Students = new List<Student>();
    }

    public void AddStudent()
    {
        Console.WriteLine("Введите имя студента: ");
        string name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Невалидный ввод. Попробуйте снова.");
            return;
        }

        Console.WriteLine("Введите фамилию студента: ");
        string secondName = Console.ReadLine();

        if (string.IsNullOrEmpty(secondName))
        {
            Console.WriteLine("Невалидный ввод. Попробуйте снова.");
            return;
        }

        Student student = new Student(name, secondName);
        Students.Add(student);
        student.AddRatings();
    }

    public void PrintStudentsList()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("Список студентов пока пуст.");
            return;
        }

        foreach (Student student in Students)
        {
            Console.WriteLine($"{student.Name} {student.SecondName}:");

            foreach (var rating in student.Evaluations)
            {
                Console.WriteLine($"{rating.Key}: {string.Join(", ", rating.Value)}");
            }

            Console.WriteLine($"\n----------------------------------Средняя оценка по всем предметам: {student.GetAverage():F2}");
        }
    }

    public Student GetStudent()
    {
        Console.WriteLine("Введите имя студента: ");
        string name = Console.ReadLine();

        Console.WriteLine("Введите фамилию студента: ");
        string secondName = Console.ReadLine();

        foreach (Student student in Students)
        {
            if (student.Name == name && student.SecondName == secondName)
            {
                return student;
            }
        }

        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Class studentsClass = new Class();

        bool isExit = false;

        while (!isExit)
        {
            Console.WriteLine("Введите действие:\n1 - Вывести список всех студентов\n2 - Добавить студента\n3 - Получить среднюю оценку студента\n4 - Выход");
            int choice = int.Parse(Console.ReadLine());

            if (choice <= 0 || choice > 4)
            {
                Console.WriteLine("Ошибка выбора. Введите снова.");
                continue;
            }

            try
            {
                switch (choice)
                {
                    case 1:
                        studentsClass.PrintStudentsList();
                        break;

                    case 2:
                        studentsClass.AddStudent();
                        break;

                    case 3:
                        Student specificStudent = studentsClass.GetStudent();
                        if (specificStudent != null)
                        {
                            Console.WriteLine($"Средняя оценка студента {specificStudent.Name} {specificStudent.SecondName}: {specificStudent.GetAverage():F2}");
                        }
                        else
                        {
                            Console.WriteLine("Студент не найден.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Выход.");
                        isExit = true;
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}*/

/*Задание 37: Книга контактов
Создать консольное приложение для хранения контактов (имя, телефон, email).
Реализовать функции добавления, удаления, редактирования и поиска
контактов*/



/*public class ContactList
{
    public List<Contact> Contacts { get; set;}

    public ContactList()
    {
        Contacts = new List<Contact>();
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }

    public void AddContact()
    {
        Console.WriteLine("Введите имя: ");
        string name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Имя не может быть пустым. Попробуйте снова.");
            return;
        }

        Console.WriteLine("Введите мейл: ");
        string email = Console.ReadLine();

        if (string.IsNullOrEmpty(email))
        {
            Console.WriteLine("Мейл не может быть пустым. Попробуйте снова.");
            return;
        }

        Console.WriteLine("Введите номер телефона: ");
        string phone = Console.ReadLine();

        if (string.IsNullOrEmpty(phone))
        {
            Console.WriteLine("Телефон не может быть пустым. Попробуйте снова.");
            return;
        }

        try
        {
            Contact contact = new Contact(name, email, phone);
            Contacts.Add(contact);
        }

        catch (Exception ex) 
        {
            Console.WriteLine("Ошибка добавления контакта: " + ex.Message);
        }
    }

    public void RemoveContact()
    {
        Contact searchContact = GetContact();

        if (searchContact == null)
        {
            Console.WriteLine("Контакт не найден. Попробуйте снова.");
        }

        else
        {
            try
            {
                Contacts.Remove(searchContact);
                Console.WriteLine("Контакт удален.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка удаления: " + ex.Message);
            }
        }
        
    }

    public Contact GetContact()
    {
        Console.WriteLine("Введите вариант поиска:\n1 - по имени\n2 - по мейлу\n3 - по номеру телефона");
        int choice = int.Parse(Console.ReadLine());

        if (choice <= 0 || choice > 3)
        {
            Console.WriteLine("Ошибка ввода. Попробуйте снова.");
            return null;
        }

        Console.WriteLine("Введите значение для поиска:");
        string searchValue = Console.ReadLine();

        bool isFound = false;

        foreach (Contact contact in Contacts)
        {
            switch (choice)
            {
                case 1:
                    if (contact.Name == searchValue)
                    {
                        return contact;
                        isFound = true;
                    }
                    break;

                case 2:
                    if (contact.Email == searchValue)
                    {
                        return contact;
                        isFound = true;

                    }
                    break;

                case 3:
                    if (contact.Phone == searchValue)
                    {
                        return contact;
                        isFound = true;

                    }
                    break;
            }
        }

        if (!isFound)
        {
            return null;
        }

        return null;
    }

    public void ChangeContact()
    {
        Contact searchContact = GetContact();

        if (searchContact == null)
        {
            Console.WriteLine("Ошибка изменения контакта. Контакт не найден.");
            return;
        }

        else
        {
            try
            {
                bool isExit = false;
                while(!isExit)
                {
                    Console.WriteLine("Введите опцию для изменения:\n1 - номер телефона\n2 - мейл\n3 - имя\n4 - выход");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == null || choice <= 0 || choice > 4)
                    {
                        Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                        return;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Введите номер для замены: ");
                            string changePhone = Console.ReadLine();

                            searchContact.Phone = changePhone;
                            break;

                        case 2:
                            Console.WriteLine("Введите мейл для замены: ");
                            string changeMail = Console.ReadLine();

                            searchContact.Email = changeMail;
                            break;

                        case 3:
                            Console.WriteLine("Введите имя для замены:");
                            string changeName = Console.ReadLine();

                            searchContact.Name = changeName;
                            break;

                        case 4:
                            isExit = true;
                            break;
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Ошибка изменения контакта: " + e.Message);
            }
        }
    }

    public void PrintAllContacts()
    {
        if (Contacts.Count == 0) 
        {
            Console.WriteLine("Список контактов пока пуст.");
            return;
        }

        Console.WriteLine("Имя\tМейл\t\tТелефон");
        foreach (Contact contact in Contacts)
        {
            Console.WriteLine($"{contact.Name}\t{contact.Email}\t{contact.Phone}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContactList contactList = new ContactList();

        bool isExit = false;
        while(!isExit)
        {
            Console.WriteLine("Введите действие:\n1 - Вывести список контактов\n2 - Добавить контакт\n3 - Изменить контакт\n4 - Удалить контакт\n5 - Найти контакт\n6 - Выйти");
            int choice = int.Parse(Console.ReadLine());

            if (choice == null || choice <= 0 || choice > 6)
            {
                Console.WriteLine("Ошибка ввода. Введите снова");
                return;
            }

            try
            {
                switch (choice)
                {
                    case 1:
                        contactList.PrintAllContacts();
                        break;

                    case 2:
                        contactList.AddContact();
                        break;

                    case 3:
                        contactList.ChangeContact();
                        break;

                    case 4:
                        contactList.RemoveContact();
                        break;

                    case 5:
                        contactList.GetContact();
                        break;

                    case 6:
                        isExit = true;
                        break;
                }
            }

            catch (Exception e) 
            { 
                Console.WriteLine("Ошибка: " + e.Message); 
            }
        }
    }
}*/

/*class TicTacToeGame
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    static void InitializateBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    static void PrintBoard()
    {
        Console.Clear();

        Console.WriteLine(" 1 | 2 | 3");

        Console.WriteLine(" ---------");

        Console.WriteLine(" 4 | 5 | 6");

        Console.WriteLine(" ---------");

        Console.WriteLine(" 7 | 8 | 9\n");


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + board[i, j] + " |");
            }
            Console.WriteLine();
            Console.WriteLine(" ---------");
        }
    }

    static void MakeMove()
    { 
        Console.Write("Игрок " + currentPlayer + ", введите движение (1-9): ");

        int move = int.Parse(Console.ReadLine());

        int row = (move - 1) / 3;

        int col = (move - 1) % 3;

        if (board[row, col] != ' ')
        {
            Console.WriteLine("Невозможное движение, попробуйте снова.");
            MakeMove();
        }
        else
        {
            board[row, col] = currentPlayer;
        }
    }


    static void CheckWin()
    {
        for (int i = 0; i < 3; i++)
        { 
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
            {
                Console.WriteLine("Игрок " + board[i, 0] + " победил!");
                Environment.Exit(0);
            }
        }

        for (int i = 0; i < 3; i++)

        {
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
            {
                Console.WriteLine("Игрок " + board[0, i] + " победил!");
                Environment.Exit(0);
            }

        }

        if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ') ||
            (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' '))
        {
            Console.WriteLine("Игрок " + board[1, 1] + " победил!");
            Environment.Exit(0);
        }

    }


    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static void Main(string[] args)
    {
        InitializateBoard();

        while(true)
        {
            PrintBoard();
            MakeMove();
            CheckWin();
            SwitchPlayer();
        }
    }
}*/

/*Задание 39: Игра "Быки и коровы"
Создать игру "Быки и коровы", где игрок должен угадать загаданное
программой четырехзначное число*/

/*class BullsAndCowsGame
{
    private int cows;
    private int bulls;
    private int countOfMoves;
    private int randomNum;
    private int userNum;

    public BullsAndCowsGame()
    {
        cows = 0;
        bulls = 0;
        countOfMoves = 0;

        PlayGame();
    }

    public int Cows { get => cows; }
    public int Bulls { get => bulls; }
    public int CountOfMoves { get => countOfMoves; }

    private void GetRandomNum()
    {
        Random random = new Random();
        randomNum = random.Next(1000, 10000);
    }

    private void CheckCowsAndBulls()
    {
        char[] randomChars = randomNum.ToString().ToCharArray();
        char[] userChars = userNum.ToString().ToCharArray();

        cows = 0;
        bulls = 0;

        for (int i = 0; i < 4; i++)
        {
            if (randomChars[i] == userChars[i])
            {
                bulls++;
            }
            else if (randomChars.Contains(userChars[i]))
            {
                cows++;
            }
        }
    }

    private void GetUserNum()
    {
        Console.WriteLine("Введите число: ");
        int num = 0;

        while (true)
        {
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                continue;
            }

            if (num < 1000 || num > 9999)
            {
                Console.WriteLine("Ошибка ввода. Число должно быть 4-значным.");
                continue;
            }

            userNum = num;
            break;
        }
    }

    private bool CheckWin()
    {
        if (bulls == 4)
        {
            Console.WriteLine("Поздравляем! Вы угадали число!");
            return true;
        }

        countOfMoves++;
        Console.WriteLine("Коровы: " + cows);
        Console.WriteLine("Быки: " + bulls);
        Console.WriteLine("Попыток: " + countOfMoves);

        cows = 0;
        bulls = 0;

        return false;
    }

    private void PlayGame()
    {
        GetRandomNum();

        while (true)
        {
            GetUserNum();
            CheckCowsAndBulls();
            if (CheckWin()) break;
        }
    }

    static void Main(string[] args)
    {
        BullsAndCowsGame game = new BullsAndCowsGame();
    }
}*/


/*Задание 40: Симуляция банкомата
Написать программу, которая симулирует работу банкомата: внесение средств,
снятие средств, просмотр баланса*/
using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.Design;

//public class ATMMachine
//{
//    public List<BankUser> bankUsers { get; set; }

//    public ATMMachine()
//    {
//        bankUsers = new List<BankUser>();
//    }

//    public void DepositFunds(BankUser user)
//    {
//        Console.WriteLine("Введите сумму для внесения: ");
//        int amount;
//        while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
//        {
//            Console.WriteLine("Неверная сумма. Попробуйте снова.");
//        }

//        user.BankAccount += amount;
//    }

//    public void WithdrawFunds(BankUser user)
//    {
//        Console.WriteLine("Введите сумму для снятия: ");
//        int amount;
//        while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
//        {
//            Console.WriteLine("Неверная сумма. Попробуйте снова.");
//        }

//        if (user.BankAccount < amount)
//        {
//            Console.WriteLine("Недостаточно средств на счете.");
//            return;
//        }

//        user.BankAccount -= amount;
//    }

//    public void ViewBalance(BankUser user)
//    {
//        Console.WriteLine($"Ваш баланс: {user.BankAccount}");
//    }

//    public void AddUser()
//    {
//        try
//        {
//            bankUsers.Add(BankUser.Registration());
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Ошибка добавления пользователя: " + ex.Message);
//            return;
//        }
//    }
//}

//public class BankUser
//{
//    public string Nikname { get; set; }
//    private string Password { get; set; }
//    public int BankAccount { get; set; }

//    private bool isAuth { get; set; }

//    private Dictionary<string, string> UserData;

//    public BankUser(string name, string password)
//    {
//        Nikname = name;
//        Password = password;
//        UserData = new Dictionary<string, string>();
//        isAuth = false;

//        BankAccount = 0;
//    }

//    public static BankUser Registration()
//    {
//        Console.WriteLine("Введите имя пользователя: ");
//        string name = Console.ReadLine();

//        while (string.IsNullOrEmpty(name))
//        {
//            Console.WriteLine("Поле имени не может быть пустым. Попробуйте снова");
//            name = Console.ReadLine();
//        }

//        Console.WriteLine("Введите пароль: ");
//        string password = Console.ReadLine();

//        while (string.IsNullOrEmpty(password))
//        {
//            Console.WriteLine("Пароль не может быть пустым. Попробуйте снова.");
//            password = Console.ReadLine();
//        }

//        BankUser newUser = new BankUser(name, password);

//        return newUser;
//    }

//    public void Authorization(List<BankUser> listUsers)
//    {
//        int attempts = 0;
//        while (attempts < 3)
//        {
//            Console.WriteLine("Введите имя пользователя: ");
//            string authName = Console.ReadLine();

//            if (string.IsNullOrEmpty(authName))
//            {
//                Console.WriteLine("Имя пользователя не может быть пустым. Введите снова.");
//                attempts++;
//                continue;
//            }

//            Console.WriteLine("Введите пароль: ");
//            string authPass = Console.ReadLine();

//            if (string.IsNullOrEmpty(authPass))
//            {
//                Console.WriteLine("Пароль не может быть пустым. Попробуйте снова.");
//                attempts++;
//                continue;
//            }

//            foreach (BankUser user in listUsers)
//            {
//                if (user.Nikname == authName && user.Password == authPass)
//                {
//                    Console.WriteLine("Авторизация прошла успешно.");
//                    user.isAuth = true;
//                    return;
//                }
//            }

//            Console.WriteLine("Неверное имя пользователя или пароль. Попробуйте снова.");
//            attempts++;
//        }

//        Console.WriteLine("Превышен лимит попыток. Авторизация не удалась.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ATMMachine bank = new ATMMachine();

//        int choice;
//        while (true)
//        {
//            Console.WriteLine("Введите действие:\n1 - Зарегистрировать пользователя\n2 - Авторизоваться\n" +
//                "3 - Внести наличные\n4 - Снять наличные\n5 - Показать абаланс\n6 - Выход");

//            try
//            {
//                choice = int.Parse(Console.ReadLine());
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    bank.AddUser();
//                    break;
//                case 2:
//                    BankUser user = new BankUser("", "");
//                    user.Authorization(bank.bankUsers);
//                    break;
//                case 3:
//                    Console.WriteLine("Введите имя пользователя: ");
//                    string depositUserName = Console.ReadLine();

//                    BankUser depositUser = bank.bankUsers.Find(u => u.Nikname == depositUserName);

//                    if (depositUserName == null)
//                    {
//                        Console.WriteLine("Пользователь не найден.");
//                    }

//                    else
//                    {
//                        bank.DepositFunds(depositUser);
//                    }
//                    break;

//                case 4:
//                    Console.WriteLine("Введите имя пользователя: ");
//                    string withdrawFundsUser = Console.ReadLine();

//                    BankUser withdrawFundUser = bank.bankUsers.Find(u => u.Nikname ==  withdrawFundsUser);

//                    if (withdrawFundUser == null)
//                    {
//                        Console.WriteLine("Имя пользователя не может быть пустым.");
//                    }

//                    else
//                    {
//                        bank.WithdrawFunds(withdrawFundUser);
//                    }

//                    break;

//                case 5:
//                    Console.WriteLine("Введите имя пользователя: ");
//                    string name = Console.ReadLine();

//                    BankUser userBalance = bank.bankUsers.Find(u =>u.Nikname == name);

//                    if (userBalance == null)
//                    {
//                        Console.WriteLine("Пользователь не найден.");
//                    }

//                    else
//                    {
//                        bank.ViewBalance(userBalance);
//                    }
//                    break;
//                case 6:
//                    Environment.Exit(0);
//                    break;
//                default:
//                    Console.WriteLine("Ошибка ввода.");
//                    break;
//            }
//        }
//    }
//}

/*Задание 41: Парсинг CSV-файлов
Создать программу, которая читает данные из CSV-файла и выводит их в
формате таблицы.*/
/*
Файл записан вручную, смотри persons.csv в папке проекта*/

/*public class CSVReader
{
    public void ReadCSVFile(string filePath)
    {
        CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = false,
            Comment = '#',
            AllowComments = true,
            Delimiter = ",",
        };

        using StreamReader streamReader = File.OpenText(filePath);
        using CsvReader reader = new CsvReader(streamReader, csvConfiguration);

        var records = reader.GetRecords<Person>();

        Console.WriteLine($"{"Name",-15} {"Surname",-15} {"Profession",-20}");
        Console.WriteLine(new string('-', 50));

        foreach (var person in records)
        {
            Console.WriteLine($" {person.Name,-15} {person.Surname,-15} {person.Occupation,-20}");
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Occupation { get; set; }

    public Person(string name, string surname, string occupation)
    {
        Name = name;
        Surname = surname;
        Occupation = occupation;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CSVReader reader = new CSVReader();
        reader.ReadCSVFile("persons.csv");
    }
}*/

/*Задание 42: Калькулятор средней температуры
Разработать приложение, которое вычисляет среднюю температуру за неделю
по введенным пользователем данным*/

/*public class AverageTemperatureCalculator
{
    public int[] daysTemperature {  get; set; }

    public AverageTemperatureCalculator()
    {
        daysTemperature = new int[7];
        AddDaysTemp();
    }

    public void AddDaysTemp()
    {
        Console.WriteLine("Вводите по очереди температуру в каждый из дней недели: ");
        for (int i = 0; i < daysTemperature.Length; i++)
        {
            while (true)
            {
                Console.WriteLine($"День: {i + 1}");
                if (int.TryParse(Console.ReadLine(), out int temperature))
                {
                    daysTemperature[i] = temperature;
                    break;
                }

                else
                {
                    Console.WriteLine("Неверный ввод.");
                }
            }
        }
        CalculateAverageTemperature();
    }

    public void CalculateAverageTemperature()
    {
        int sum = 0;
        foreach (int i in daysTemperature)
        {
            sum += i;
        }
        Console.WriteLine("Средняя температура за неделю: " + sum / 7 + "°C");
    }

    static void Main(string[] args)
    {
        AverageTemperatureCalculator calculator = new AverageTemperatureCalculator();
    }
}*/

/*Задание 44: Автоматический контроль версий
Создать программу, которая отслеживает изменения в текстовых файлах в
указанной директории и автоматически сохраняет копии изменений с отметкой
времени*/
/*public class VersionControler
{
    private readonly string _directoryPath;
    private readonly string _backupDirectoryPath;

    public VersionControler(string directoryPath, string backUpDirectoryPath)
    {
        _directoryPath = directoryPath;
        _backupDirectoryPath = backUpDirectoryPath;
    }

    public void StartWatching()
    {
        using (var watcher = new FileSystemWatcher(_directoryPath))
        {
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.txt";
            watcher.Changed += OnChanged;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"Отслеживание файла {_directoryPath} началось.");
            Console.ReadLine();
        }
    }

    private void OnChanged(object source, FileSystemEventArgs e)
    {
        Console.WriteLine($"Файл {e.FullPath} был изменен.");

        string backupDirectoryPath = $"{_backupDirectoryPath}\\{e.Name}";
        string backupFilePath = $"{backupDirectoryPath}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";

        if (!Directory.Exists(backupDirectoryPath))
        {
            Directory.CreateDirectory(backupDirectoryPath);
        }

        File.Copy(e.FullPath, backupFilePath, true);

        Console.WriteLine($"Резервная копия сохранена в {backupFilePath}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //В корневой папке проекта можете посмотреть результат
        string directoryPath = "C:\\Users\\RxGroup\\Desktop\\4 code\\projects\\educational practice\\educational practice\\bin\\Debug\\net8.0";
        string backupDirectoryPath = @"C:\Users\RxGroup\Desktop\4 code\projects\educational practice\educational practice\bin\Debug\net8.0\backups";

        VersionControler controler = new VersionControler(directoryPath, backupDirectoryPath);
        controler.StartWatching();
    }
}
*/

/*Задание 45: Генерация отчетов
Написать программу, которая генерирует отчет в текстовом формате на основе
введенных пользователем данных (например, отчет по продажам, отчет по
выполнению задач и т.д.)*/


/*class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите данные для отчета (в формате дата;описание;сумма, дата;описание;сумма, ...): ");
        string reportData = Console.ReadLine();

        try
        {
            string[] dataRows = reportData.Split(',');

            Console.WriteLine("Отчет:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("| Дата       | Описание          | Сумма      |");
            Console.WriteLine("---------------------------------------------------");

            int rowIndex = 1;
            foreach (string dataRow in dataRows)
            {
                string[] columns = dataRow.Split(';');

                if (columns.Length != 3)
                {
                    throw new Exception($"Неверный формат ввода: {dataRow}");
                }

                Console.WriteLine($"| {columns[0].PadRight(10)} | {columns[1].PadRight(20)} | {columns[2].PadRight(10)} |");

                rowIndex++;
            }

            Console.WriteLine("---------------------------------------------------");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}*/

/*public class PublicEvent
{
    public List<Visitor> listOfVisitors { get; set; }

    public PublicEvent()
    {
        listOfVisitors = new List<Visitor>();
    }

    public void AddVisitors()
    {
        Console.WriteLine("Введите количество посетителей: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Clear();

            string name;
            while (true)
            {
                Console.WriteLine("Введите имя посетителя: ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                Console.WriteLine("Ошибка ввода. Имя не может быть пустым.");
            }

            string surname;
            while (true)
            {
                Console.WriteLine("Введите фамилию посетителя: ");
                surname = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(surname))
                {
                    break;
                }

                Console.WriteLine("Ошибка ввода. Фамилия не может быть пустой.");
            }

            int age;
            while (true)
            {
                Console.WriteLine("Введите возраст посетителя: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    break;
                }

                Console.WriteLine("Ошибка ввода. Возраст не может быть отрицательным или равным нулю.");
            }

            Visitor newVisitor = new Visitor(name, surname, age);
            listOfVisitors.Add(newVisitor);

            Console.WriteLine("Посетитель добавлен.");
        }
    }

    public void RemoveVisitors(string targetName)
    {
        if (listOfVisitors.Count <= 0)
        {
            Console.WriteLine("Список посетителей всё еще пуст. Добавьте посетителей.");
            return;
        }

        for (int i = listOfVisitors.Count - 1; i >= 0; i--)
        {
            if (listOfVisitors[i].Name == targetName)
            {
                try
                {
                    listOfVisitors.RemoveAt(i);
                    Console.WriteLine("Пользователь удален.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка удаления пользователя. Попробуйте снова.");
                    return;
                }
            }
        }

        Console.WriteLine("Посетитель с таким именем не найден.");
    }

    public void PrintListOfVisitors()
    {
        if (listOfVisitors == null || listOfVisitors.Count <= 0)
        {
            Console.WriteLine("Список посетителей все еще пуст. Попробуйте снова.");
            return;
        }

        Console.WriteLine($"Количество посетителей: {listOfVisitors.Count}:\n\nИмя\tФамилия\tВозраст\tСтатус");
        foreach (var visitor in listOfVisitors)
        {
            string status = visitor.isHere ? "Присутствует" : "Отсутствует";
            Console.WriteLine($"{visitor.Name}\t{visitor.Surname}\t{visitor.Age}\t{status}");
        }
    }

    public void MarkAsHere(string targetName)
    {
        if (listOfVisitors == null || listOfVisitors.Count <= 0)
        {
            Console.WriteLine("Список все еще пуст. Добавьте посетителей.");
            return;
        }

        foreach (var visitor in listOfVisitors)
        {
            if (visitor.Name == targetName)
            {
                try
                {
                    visitor.isHere = true;
                    Console.WriteLine("Посетитель отмечен.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                    return;
                }
            }
        }
    }

    public class Visitor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool isHere;

        public Visitor(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            isHere = false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PublicEvent eventManager = new PublicEvent();

        while (true)
        {
            Console.WriteLine("Введите действие:\n1 - Добавить посетителей\n2 - Удалить посетителей\n3 - Отметить как пришедшего\n4 - Вывести список посетителей\n5 - Выход ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    eventManager.AddVisitors();
                    break;
                case 2:
                    Console.WriteLine("Введите имя посетителя для удаления: ");
                    string targetName = Console.ReadLine();
                    eventManager.RemoveVisitors(targetName);
                    break;
                case 3:
                    Console.WriteLine("Введите имя посетителя для отметки: ");
                    targetName = Console.ReadLine();
                    eventManager.MarkAsHere(targetName);
                    break;
                case 4:
                    eventManager.PrintListOfVisitors();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}*/


/*Задание 47: Планировщик задач
Разработать программу, которая позволяет пользователю создавать задачи,
задавать для них время выполнения и уведомляет о наступлении времени
выполнения задачи*/



/*public class TaskScheduler
{
    private Timer Timer { get; set; }
    private List<Task> tasks { get; set; }

    public TaskScheduler()
    {
        tasks = new List<Task>();
        Timer = new Timer(CheckTimeForTask, null, 1000, 1000);
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(string name)
    {
        Task targetTask = tasks.FirstOrDefault(task => task.Name == name);
        if (targetTask != null)
        {
            tasks.Remove(targetTask);
            Console.WriteLine("Задача удалена.");
        }
        else
        {
            Console.WriteLine("Задача с таким именем не найдена.");
        }
    }

    public void PrintTasksList()
    {
        Console.WriteLine("Задача\tВремя выполнения\tСтатус");
        foreach (var task in tasks)
        {
            string status = task.IsCompleted ? "Ожидает выполнения" : "Выполнена";
            Console.WriteLine($"{task.Name}\t{task.ExecutionTime}\t{status}");
        }
    }

    public void CheckTimeForTask(object state)
    {
        foreach(var task in tasks)
        {
            if (task.ExecutionTime <= DateTime.Now && !task.IsCompleted)
            {
                NotifyUser(task);
                task.IsCompleted = true;
            }
        }
    }

    private void NotifyUser(Task task)
    {
        Console.WriteLine($"Пришло время для выполнения задачи: {task.Name}");
    }
    public class Task
    {
        public string Name { get; set; }
        public DateTime ExecutionTime { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string name, DateTime executionTime)
        {
            Name = name;
            ExecutionTime = executionTime;
            IsCompleted = false;
        }
    }

    static void Main(string[] args)
    {
        TaskScheduler scheduler = new TaskScheduler();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Добавить задачу");
            Console.WriteLine("2 - Удалить задачу");
            Console.WriteLine("3 - Вывести список задач");
            Console.WriteLine("4 - Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите имя задачи: ");
                    string taskName = Console.ReadLine();

                    Console.Write("Введите время выполнения задачи (в формате dd.MM.yyyy HH:mm): ");
                    try
                    {
                        DateTime executionTime = DateTime.Parse(Console.ReadLine());
                        Task task = new Task(taskName, executionTime);
                        scheduler.AddTask(task);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка ввода времени выполнения задачи.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите имя задачи: ");
                    string name = Console.ReadLine();
                    scheduler.RemoveTask(name);
                    break;
                case 3:
                    scheduler.PrintTasksList();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                    break;
            }
        }
    }
}

*/


/*Задание 48: Анализ продаж
Написать приложение, которое анализирует данные о продажах и выводит
статистику по проданным товарам (общая сумма продаж, количество проданных
единиц каждого товара и т.д.)*/

public class SalesAnalyst
{   
    public List<Product> Products;
    public int CountOfSales {  get; set; }
    public double SaleSum { get; set; }

    public SalesAnalyst() 
    {
        Products = new List<Product>();
        CountOfSales = 0;
        SaleSum = 0;
    }   

    public void AddProduct()
    {
        Console.WriteLine("Введите наименование продукта: ");
        string name = Console.ReadLine();

        if (name == null || string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Имя товара не может быть пустым. Попробуйте снова.");
            Console.Clear();
            return;
        }

        Console.WriteLine("Введите цену товара: ");
        double price = double.Parse(Console.ReadLine());

        if (price <= 0)
        {
            Console.WriteLine("Цена товара не может быть меньше или равна нулю. Введите снова.");
            Console.Clear();
            return;
        }

        Console.WriteLine("Введите количество продукта: ");
        int count = int.Parse(Console.ReadLine());

        if (count <= 0)
        {
            Console.WriteLine("Количество товара не может быть меньше или равно нулю. Введите снова.");
            Console.Clear();
            return;
        }

        try
        {
            Product newProduct = new Product(name, price, count);
            Products.Add(newProduct);
            Console.WriteLine("Товар добавлен.");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка добавления товара: {ex.Message}. Попробуйте снова.");
            Console.Clear();
            return;
        }
    }

    public void SellProduct(SalesAnalyst analyst)
    {
        Console.WriteLine("Введите имя товара для продажи: ");
        string name = Console.ReadLine() ;

        if (name == null || string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Имя товара не может быть пустым. Попробуйте снова.");
            Console.Clear();
            return;
        }

        bool isFind = false;
        foreach (Product product in Products)
        {
            if (product.Name == name)
            {
                Console.WriteLine("Введите количество единиц товара для продажи: ");
                int countOfSale = int.Parse(Console.ReadLine());

                if (countOfSale <= 0)
                {
                    Console.WriteLine("Количество продаж не может быть меньше или равно нулю. Попробуйте снова.");
                    Console.Clear();
                    return;
                }

                else if (product.Count < countOfSale)
                {
                    Console.WriteLine("Количество продаж превышает количество имеющегося товара. Попробуйте снова.");
                    Console.Clear();
                    return;
                }

                else
                {
                    isFind = true;

                    try
                    {
                        product.Count -= countOfSale;
                        product.numberOfSales += countOfSale;
                        analyst.CountOfSales += countOfSale;
                        analyst.SaleSum += countOfSale * product.Price;

                        Console.Clear();
                        Console.WriteLine("Товар успешно продан.");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка продажи товара: {ex.Message}");
                        Console.Clear();
                        return;
                    }
                }
            }
        }

        if (!isFind)
        {
            Console.WriteLine("Товар с таким именем не найден. Попробуйте снова.");
            Console.Clear();
            return;
        }
    }

    public void PrintProductList(SalesAnalyst analyst)
    {
        if (Products.Count <= 0)
        {
            Console.WriteLine("Список товаров все еще пуст. Добавьте товары.");
            Console.Clear();
            return;
        }

        Console.WriteLine($"Название товара\tЦена товара\tКоличество имеющегося товара\tКоличество проданных единиц товара");
        foreach (Product product in Products)
        {
            Console.WriteLine($"{product.Name}\t{product.Price}\t{product.Count}\t{product.numberOfSales}");
        }

        Console.WriteLine($"------------------------------------------------------------------------------------------------\nИТОГО ПРОДАНО ТОВАРОВ: {analyst.CountOfSales} НА СУММУ {analyst.SaleSum}");
    }


    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int numberOfSales { get; set; }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
            numberOfSales = 0;
        }
    }

    static void Main(string[] args)
    {
        SalesAnalyst analyst = new SalesAnalyst();
        bool isExit = false;

        while (!isExit)
        {
            Console.WriteLine("Введите действие:\n1 - Добавить товар\n2 - Продать товар\n3 - Вывести список итоговый отчёт продаж\n4 - Выход");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    analyst.AddProduct();
                    break;

                case 2:
                    analyst.SellProduct(analyst);
                    break;

                case 3:
                    analyst.PrintProductList(analyst);
                    break;

                case 4:
                    isExit = true;
                    break;
                default:
                    Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                    break;
            }

        }
    }
}