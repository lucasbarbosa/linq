﻿using System;

namespace Linq.Classes
{
    public static class Titulo
    {
        public static void Exibir(string titulo)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("--- "+titulo);
            Console.WriteLine("------------------------------");
        }

        public static void ExibirSub(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine(titulo);
            Console.WriteLine("------------------------------");
        }

        public static string ExibirRead(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.Write(titulo);
            return Console.ReadLine().ToString();
        }
    }
}