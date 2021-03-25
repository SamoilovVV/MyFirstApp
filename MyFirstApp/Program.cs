/* Copyright Me
 * jjkkkk
 * lllll
 */
using System;


namespace MyFirstApp
{
    // Так делать можно, но не нужно
    // using System;

    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            // TODO make it work
            Console.WriteLine("Hello World!");
            Console.Write(" Type your name: ");
            string s = Console.ReadLine();
            Console.WriteLine("Hello " + s);
            Console.Read();
            Console.Clear();

        }
    }
}
