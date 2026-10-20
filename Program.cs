//**************************************************************************
//* Практическая работа № 12                                               *
//* Выполнил: Складаный А.А., группа 2ИСПд                                 *
//* Задание:  Организация и использование функций                          *
//**************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace работа_12
{
    internal class Program
    {
        static void HandleError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
        static string RemoveSpace(string stroka)
        {
            return stroka.Replace(" ", "");
        }

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Black; 
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.WriteLine("Введите строку для удаления никому ненужных пробелов:");
                    string stroka = Console.ReadLine();
                    string result = RemoveSpace(stroka);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\nРезультат без пробелов:\n{result}\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Хотите повторить программу?\n\n\t\t 1 = да, другое число = нет.");
                    uint povtor = Convert.ToUInt32(Console.ReadLine());
                    if (povtor != 1 ) break;
                }
            }
            catch (Exception ex) 
            {
                HandleError(ex);
            }
        }
    }
}
