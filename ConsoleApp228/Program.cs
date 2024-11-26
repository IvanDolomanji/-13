using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp228
{
    internal class Program
    {
        /// <summary>
     /// Найти минимальную величину из двух целых переменных a, b, 
     /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины,
     /// вывода результата).
     /// </summary>
     /// <param name="args"></param>
     /// 

        //public static int Min(int a, int b)
        //{ 
        //    return a < b ? a : b;
        //}
        //static int Input(string message)
        //{
        //    Console.Write(message);
        //    return int .Parse(Console.ReadLine());
        //}
        //static void Output(int min)
        //{
        //    Console.Write(min);
        //}

        //static void Main(string[] args)
        //{
        //    int x = Input("a=");
        //    int b = Input("b=");
        //    int min = Min(x, b);
        //    Output(min);


        //    Console.ReadKey();

        //2
        /// <summary>
        ///Найти минимальную величину их трех целых переменных a, b, c 
        ///с использованием вспомогательных методов 
        ///(ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="args"></param>
        /// 
        //public static int Min(int a, int b, int c)
        //{
        //    return (a <= b && a <= c) ? a : (b <= a && b <= c) ? b : c;
        //}
        //static int Input(string message)
        //{
        //    Console.Write(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void Output(int min)
        //{
        //    Console.Write(min);
        //}
        //static void Main(string[] args)
        //{
        //    int x = Input("a=");
        //    int b = Input("b=");
        //    int c = Input("c=");
        //    int min = Min(x, b, c);
        //    Output(min);
        //    Console.ReadKey();


        //3
        /// <summary>
        ////// <summary>
        /// Найти s=min(a, b) + min(c, d),
        /// используя вспомогательные функции 
        /// (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="args"></param>
        /// 

        static int Input(string messege)
        {
            Console.WriteLine(messege);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static void Output(int result)
        { 
            Console.WriteLine($"result = {result}");
        }
        static void Main(string[] args)
        {
            int x = Input("x=");
            int y = Input("y=");
            int z = Input("z=");
            int c = Input("c=");
            int result = Min(x,y) + Min(z,c);
            Output(result);
            Console.ReadKey();

         //4
         


        }



        

       
        



        
    }
 }

