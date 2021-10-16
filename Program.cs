using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)                                  // код который выполняется в первую очередь
        {
            Console.WriteLine("Введите количество строк в будущей матрице");       //приглашение ко вводу количества строк в матрице (row - ряд)
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в будущей матрице");    //вводим количество столбцов (col- column - колонка/столбец)
            int col = int.Parse(Console.ReadLine());

            int[,] array2d = new int[row, col]; //создаем двумерный массив с названием array2d, где row - строки, column - столбцы

            Random r = new Random();            //инициализируем рандомизатор для заполнения массива

            for (int i = 0; i < row; i++)       //используем цикл заполняем рандомно строки
            {
                
                for (int j = 0; j < col; j++)  //используем вложенный цикл заполняем столбцы
                {
                    array2d[i, j] = r.Next(10);         //генерируем рандомные числа в промежутке до 10
                    Console.Write($"{array2d[i, j]} ");  //выводим массив
                }

                Console.WriteLine();

            }
            int sum = 0;                       //инициализируем переменную для подсчета суммы чисел в массиве

            for (int i = 0; i < row; i++)      //используя цикл для строк
                for (int j = 0; j < col; j++)  //и для столбцов
                    sum += array2d[i, j];      //считаем сумму
            Console.WriteLine("Сумма массива равна: {0}", sum);  //выводим сумму массива
            Console.WriteLine("Для перехода ко второй части задания нажмите клавишу...");
            Console.ReadKey();
            Console.Clear();
                     
            
            // Задание №2
            
            
            Console.Write("Введите кол-во элементов массива: \t");             //запрос на ввод количества элементов

            int elementsCount = int.Parse(Console.ReadLine());                 //создаем переменную для хранения введенного числа
            int[] secondArray = new int[elementsCount];                        //генерим массив с именем second Array состоящий из количества элементов которые ввел юзер
            for (int i = 0; i < secondArray.Length; i++)                       //используем цикл и предлагаем юзеру заполнить массив своими числами
            {
                Console.Write($"\nВВедите элемент массива под индексом {i}:\t "); //
                secondArray[i] = int.Parse(Console.ReadLine());                   //
            }

            Console.Write("\nРезультат:");                                   //выводим результат используя цикл

            for (int i =0; i < secondArray.Length; i++)                          //
            {
                Console.Write(secondArray[i]);
            }
            int minValue = secondArray[0];            //создаем переменную для хранения минимального значения и
                                                      //сразу присваиваем значение указанное в массиве с индексом 0
            for (int i = 1; i < secondArray.Length; i++)   //используя цикл перебираем все числа в массиве начиная с индекса 1,
            {                                               // потому что индекс 0 у нас уже обозначен как минимальное значение
                if (secondArray[i] < minValue)              //если число из нового индекса меньше установленного minValue,
                {                                           //то перезаписываем новое значение minValue
                    minValue = secondArray[i];              //прогоняем весь массив
                }    

            }

            Console.WriteLine($"\nМинимальное число в массиве:   { minValue }" );
            Console.WriteLine("Для перехода к следующему заданию нажмите клавишу...");
            Console.ReadKey();
            Console.Clear();
            //Задание №3
            
            
            
            Console.Write("Спасибо за внимание!");
            Console.ReadKey();
        }
    }
}
