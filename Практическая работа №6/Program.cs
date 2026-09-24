//****************************************************
//*Практическая работа №6                            *
//*Сделал Егоров Н.Н, группа 2-ИСП                   *
//*Задание: определить, является ли билет счастливым *
//****************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Практическая работа №6";//задаёт значение в заголовок консоли

            int number, digit1, digit2, digit3, digit4, digit5, digit6, SumFirst, SumLast;//SumFirst - сумма первых трёх чисел номера, SumLast - сумма последних трёх чисел номера

            Console.WriteLine("Здравствуйте!");
            try
            {
                Console.Write("Введите шестизначный номер билета: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 999999 || number < 100000)//проверка числа на шестизначность
                {
                    Console.WriteLine($"Вы ввели недопустимое число: {number}");//Вывод текста с помощью интерполяции: "Вы ввели недопустимое число: (вставляется значение number)"
                }
                else
                {
                    digit6 = number % 10;//вынесение единиц (используется оператор для получения остатка от деления)
                    digit5 = (number / 10) % 10;//вынесение десяток (используется деление номера на 10 нацело и оператор для получения остатка от деления)
                    digit4 = (number / 100) % 10;//вынесение сотен (используется деление номера на 100 нацело и оператор для получения остатка от деления)
                    digit3 = (number / 1000) % 10;
                    digit2 = (number / 10000) % 10;
                    digit1 = (number / 100000) % 10;

                    SumFirst = digit1 + digit2 + digit3;//SumFirst - сумма первых трёх чисел номера
                    SumLast = digit4 + digit5 + digit6;//SumLast - сумма последних трёх чисел номера

                    switch (SumFirst == SumLast)//сумма первых трёх чисел номера равна сумме последних трёх чисел номера
                    {
                        case true://правда
                            Console.WriteLine("Ваш билет - выигрышный!");//выводится сообщение "Ваш билет - выигрышный!"
                            break;
                        default://ложь
                            Console.WriteLine("Ваш билет - проигрышный!");//выводится сообщение "Ващ билет - проигрышный!"
                            break;
                    }
                }
            }
            catch (FormatException fex)//обработчик исключения FormatException (входная строка имела неправильный формат)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так! Ошибка: {fex.Message}");//Вывод текста с помощью интерполяции: Что-то пошло не так! Ошибка: Входная строка имела неправильный формат. 
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)//обработка исключения Exception (все ошибки в целом)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так! Ошибка: {ex.Message}");//Вывод текста с помощью интерполяции: Что-то пошло не так! Ошибка: сообщение об ошибке из ex.Message
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}
